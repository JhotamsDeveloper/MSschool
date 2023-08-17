»
UC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Abstractions\ICommand.cs
	namespace 	
MSschool
 
. 
Application 
. 
Abstractions +
;+ ,
public 
	interface 
ICommand 
: 
IRequest $
{ 
} 
public		 
	interface		 
ICommand		 
<		 
	TResponse		 #
>		# $
:		% &
IRequest		' /
<		/ 0
	TResponse		0 9
>		9 :
{

 
} Î
\C:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Abstractions\ICommandHandler.cs
	namespace 	
MSschool
 
. 
Application 
. 
Abstractions +
;+ ,
public 
	interface 
ICommandHandler  
<  !
TCommnd! (
>( )
:* +
IRequestHandler, ;
<; <
TCommnd< C
>C D
whereE J
TCommndK R
:S T
ICommandU ]
{ 
} 
public		 
	interface		 
ICommandHandler		  
<		  !
TCommand		! )
,		) *
	TResponse		+ 4
>		4 5
:		6 7
IRequestHandler		8 G
<		G H
TCommand		H P
,		P Q
	TResponse		R [
>		[ \
where

 	
TCommand


 
:

 
ICommand

 
<

 
	TResponse

 '
>

' (
{ 
} ∆
SC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Abstractions\IQuery.cs
	namespace 	
MSschool
 
. 
Application 
. 
Abstractions +
;+ ,
public 
	interface 
IQuery 
< 
	TResponse !
>! "
:# $
IRequest% -
<- .
	TResponse. 7
>7 8
{ 
} †
ZC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Abstractions\IQueryHandler.cs
	namespace 	
MSschool
 
. 
Application 
. 
Abstractions +
;+ ,
public 
	interface 
IQueryHandler 
< 
TQuery %
,% &
	TResponse' 0
>0 1
:2 3
IRequestHandler 
< 
TQuery 
, 
	TResponse %
>% &
where 	
TQuery
 
: 
IQuery 
< 
	TResponse #
># $
{ 
} ß
bC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Behaviours\LoggingPipelineBehavior.cs
	namespace 	
MSschool
 
. 
Application 
. 

Behaviours )
;) *
public 
class #
LoggingPipelineBehavior $
<$ %
TRequest% -
,- .
	TResponse/ 8
>8 9
: 
IPipelineBehavior 
< 
TRequest  
,  !
	TResponse" +
>+ ,
where 	
TRequest
 
: 
IRequest 
< 
	TResponse '
>' (
{		 
private

 
readonly

 
ILogger

 
<

 #
LoggingPipelineBehavior

 4
<

4 5
TRequest

5 =
,

= >
	TResponse

? H
>

H I
>

I J
_logger

K R
;

R S
public 
#
LoggingPipelineBehavior "
(" #
ILogger# *
<* +#
LoggingPipelineBehavior+ B
<B C
TRequestC K
,K L
	TResponseM V
>V W
>W X
loggerY _
)_ `
{ 
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< 
	TResponse 
>  
Handle! '
(' (
TRequest( 0
request1 8
,8 9"
RequestHandlerDelegate: P
<P Q
	TResponseQ Z
>Z [
next\ `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 
_logger 
. 
LogInformation 
( 
$str <
,< =
typeof 
( 
TRequest 
) 
. 
Name !
,! "
DateTime 
. 
UtcNow 
) 
; 
var 
result 
= 
await 
next 
(  
)  !
;! "
_logger 
. 
LogInformation 
( 
$str =
,= >
typeof 
( 
TRequest 
) 
. 
Name !
,! "
DateTime 
. 
UtcNow 
) 
; 
return 
result 
; 
}   
}!! Í
eC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Behaviours\UnhandledExceptionBehavior.cs
	namespace 	
MSschool
 
. 
Application 
. 

Behaviours )
;) *
public 
class &
UnhandledExceptionBehavior '
<' (
TRequest( 0
,0 1
	TResponse2 ;
>; <
:= >
IPipelineBehavior 
< 
TRequest 
, 
	TResponse  )
>) *
where 	
TRequest
 
: 
IRequest 
< 
	TResponse '
>' (
{		 
private

 
readonly

 
ILogger

 
<

 
TRequest

 %
>

% &
_logger

' .
;

. /
public 
&
UnhandledExceptionBehavior %
(% &
ILogger& -
<- .
TRequest. 6
>6 7
logger8 >
)> ?
{ 
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< 
	TResponse 
>  
Handle! '
(' (
TRequest( 0
request1 8
,8 9"
RequestHandlerDelegate: P
<P Q
	TResponseQ Z
>Z [
next\ `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 
try 
{ 	
return 
await 
next 
( 
) 
;  
} 	
catch 
( 
	Exception 
ex 
) 
{ 	
var 
requestName 
= 
typeof $
($ %
TRequest% -
)- .
.. /
Name/ 3
;3 4
_logger 
. 
LogError 
( 
ex 
,  
$str! o
,o p
requestNameq |
,| }
request	~ Ö
)
Ö Ü
;
Ü á
throw 
; 
} 	
} 
} Æ
]C:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Behaviours\UnitOfWorkBehevior.cs
	namespace 	
MSschool
 
. 
Application 
. 

Behaviours )
;) *
public 
sealed 
class 
UnitOfWorkBehevior &
<& '
TRequest' /
,/ 0
	TResponse1 :
>: ;
:< =
IPipelineBehavior 
< 
TRequest 
, 
	TResponse  )
>) *
where+ 0
TRequest1 9
:: ;
notnull< C
{		 
private

 
readonly

 
IUnitOfWork

  
_unitOfWork

! ,
;

, -
public 

UnitOfWorkBehevior 
( 
IUnitOfWork )

unitOfWork* 4
)4 5
{ 
_unitOfWork 
= 

unitOfWork  
;  !
} 
public 

async 
Task 
< 
	TResponse 
>  
Handle! '
(' (
TRequest( 0
request1 8
,8 9"
RequestHandlerDelegate: P
<P Q
	TResponseQ Z
>Z [
next\ `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 
if 

( 
IsNotCommand 
( 
) 
) 
{ 	
return 
await 
next 
( 
) 
;  
} 	
try 
{ 	
using 
var 
transactionScope &
=' (
new) ,
TransactionScope- =
(= >+
TransactionScopeAsyncFlowOption> ]
.] ^
Enabled^ e
)e f
;f g
var 
response 
= 
await  
next! %
(% &
)& '
;' (
var 
saveChangesAsync  
=! "
await# (
_unitOfWork) 4
.4 5
SaveChangesAsync5 E
(E F
)F G
;G H
transactionScope 
. 
Complete %
(% &
)& '
;' (
return 
response 
; 
} 	
catch   
(   
	Exception   
)   
{!! 	
throw"" 
;"" 
}## 	
}$$ 
private&& 
static&& 
bool&& 
IsNotCommand&& $
(&&$ %
)&&% &
{'' 
return(( 
!(( 
typeof(( 
((( 
TRequest(( 
)((  
.((  !
Name((! %
.((% &
EndsWith((& .
(((. /
$str((/ 8
)((8 9
;((9 :
})) 
}** ‘
]C:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Behaviours\ValidationBehavior.cs
	namespace 	
MSschool
 
. 
Application 
. 

Behaviours )
;) *
public 
class 
ValidationBehavior 
<  
TRequest  (
,( )
	TResponse* 3
>3 4
:5 6
IPipelineBehavior7 H
<H I
TRequestI Q
,Q R
	TResponseS \
>\ ]
where^ c
TRequestd l
:m n
IRequesto w
<w x
	TResponse	x Å
>
Å Ç
{ 
private		 
readonly		 
IEnumerable		  
<		  !

IValidator		! +
<		+ ,
TRequest		, 4
>		4 5
>		5 6
_validators		7 B
;		B C
public 

ValidationBehavior 
( 
IEnumerable )
<) *

IValidator* 4
<4 5
TRequest5 =
>= >
>> ?

validators@ J
)J K
{ 
_validators 
= 

validators  
;  !
} 
public 

async 
Task 
< 
	TResponse 
>  
Handle! '
(' (
TRequest( 0
request1 8
,8 9"
RequestHandlerDelegate: P
<P Q
	TResponseQ Z
>Z [
next\ `
,` a
CancellationTokenb s
cancellationToken	t Ö
)
Ö Ü
{ 
if 

( 
_validators 
. 
Any 
( 
) 
) 
{ 	
var 
context 
= 
new 
ValidationContext /
</ 0
TRequest0 8
>8 9
(9 :
request: A
)A B
;B C
var 
validationResult  
=! "
await# (
Task) -
.- .
WhenAll. 5
(5 6
_validators6 A
.A B
SelectB H
(H I
vI J
=>K M
vN O
.O P
ValidateAsyncP ]
(] ^
context^ e
,e f
cancellationTokeng x
)x y
)y z
)z {
;{ |
var 
failures 
= 
validationResult +
.+ ,

SelectMany, 6
(6 7
r7 8
=>9 ;
r< =
.= >
Errors> D
)D E
.E F
WhereF K
(K L
fL M
=>N P
fQ R
!=S U
nullV Z
)Z [
.[ \
ToList\ b
(b c
)c d
;d e
if 
( 
failures 
. 
Count 
!= !
$num" #
)# $
{ 
throw 
new 
	Exception #
.# $
ValidationEx$ 0
(0 1
failures1 9
)9 :
;: ;
} 
} 	
return 
await 
next 
( 
) 
; 
} 
} ”
ZC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Constants\CategoryOrdering.cs
	namespace 	
MSschool
 
. 
Application 
. 
	Constants (
;( )
public 
static 
class 
CategoryOrdering $
{ 
public 

const 
string 
nameAsc 
=  !
$str" +
;+ ,
public 

const 
string 
nameDesc  
=! "
$str# -
;- .
public 

const 
string 
idAsc 
= 
$str  '
;' (
public 

const 
string 
idDesc 
=  
$str! )
;) *
}		 ú
jC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Constants\Pagination\PaginationHandlerKeys.cs
	namespace 	
MSschool
 
. 
Application 
. 
	Constants (
.( )

Pagination) 3
;3 4
public 
static 
class !
PaginationHandlerKeys )
{ 
public 

const 
string 
sortkey 
=  !
$str" (
;( )
public 

const 
string 
	searchkey !
=" #
$str$ ,
;, -
public 

const 
string 
pageindexkey $
=% &
$str' 2
;2 3
public 

const 
string 
pagesizekey #
=$ %
$str& 0
;0 1
}		 µ
`C:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Constants\SupportedDocumentTypes.cs
	namespace 	
MSschool
 
. 
Application 
. 
	Constants (
;( )
public 
enum "
SupportedDocumentTypes "
{ 
Cedula_ciudadania 
= 
$num 
, 
Tarjeta_identidad 
= 
$num 
, 
	Pasaporte 
= 
$num 
, 
Cedula_extranjeria 
= 
$num 
, 
Otros		 	
=		
 
$num		 
}

  
cC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Constants\UnitOfWorkSaveChangesEnum.cs
	namespace 	
MSschool
 
. 
Application 
. 
	Constants (
;( )
public 
enum %
UnitOfWorkSaveChangesEnum %
{ 
Failed 

= 
$num 
, 
Saved 	
=
 
$num 
} ‡
bC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Contracts\Persistence\IAuditContex.cs
	namespace 	
MSschool
 
. 
Application 
. 
	Contracts (
.( )
Persistence) 4
;4 5
public 
	interface 
IAuditContex 
{ 
string 

?
 
GetUserFromRecord 
( 
) 
;  
} Œ
SC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\DependencyInjection.cs
	namespace 	
MSschool
 
. 
Application 
{ 
public 

static 
class 
DependencyInjection +
{		 
public

 
static

 
IServiceCollection

 (
AddAplication

) 6
(

6 7
this 
IServiceCollection #
services$ ,
), -
{ 	
var 
assemby 
= 
typeof  
(  !
DependencyInjection! 4
)4 5
.5 6
Assembly6 >
;> ?
services 
. 

AddMediatR 
(  
configuration  -
=>. 0
{ 
configuration 
. (
RegisterServicesFromAssembly :
(: ;
assemby; B
)B C
;C D
configuration 
. 
AddOpenBehavior -
(- .
typeof. 4
(4 5
UnitOfWorkBehevior5 G
<G H
,H I
>I J
)J K
)K L
;L M
} 
) 
; 
services 
. %
AddValidatorsFromAssembly .
(. /
assemby/ 6
)6 7
;7 8
services 
. 
	AddScoped 
( 
typeof 
( 
IPipelineBehavior (
<( )
,) *
>* +
)+ ,
,, -
typeof 
( &
UnhandledExceptionBehavior 1
<1 2
,2 3
>3 4
)4 5
)5 6
;6 7
services 
. 
	AddScoped 
( 
typeof 
( 
IPipelineBehavior (
<( )
,) *
>* +
)+ ,
,, -
typeof 
( 
ValidationBehavior )
<) *
,* +
>+ ,
), -
)- .
;. /
services 
. 
	AddScoped 
( 
typeof   
(   
IPipelineBehavior   (
<  ( )
,  ) *
>  * +
)  + ,
,  , -
typeof!! 
(!! #
LoggingPipelineBehavior!! .
<!!. /
,!!/ 0
>!!0 1
)!!1 2
)!!2 3
;!!3 4
return## 
services## 
;## 
}$$ 	
}%% 
}'' ‚
WC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Exceptions\BadRequestEx.cs
	namespace 	
MSschool
 
. 
Application 
. 

Exceptions )
;) *
public 
class 
BadRequestEx 
:  
ApplicationException 0
{ 
public 

BadRequestEx 
( 
string 
? 
message  '
)' (
:) *
base+ /
(/ 0
message0 7
)7 8
{ 
} 
}		 Î
ZC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Exceptions\ErrorInternalEx.cs
	namespace 	
MSschool
 
. 
Application 
. 

Exceptions )
;) *
public 
class 
ErrorInternalEx 
:  
ApplicationException 3
{ 
public 

ErrorInternalEx 
( 
string !
?! "
message# *
)* +
:, -
base. 2
(2 3
message3 :
): ;
{ 
} 
}		 ù
UC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Exceptions\NotFoundEx.cs
	namespace 	
MSschool
 
. 
Application 
. 

Exceptions )
;) *
public 
class 

NotFoundEx 
:  
ApplicationException .
{ 
public 


NotFoundEx 
( 
string 
name !
,! "
object# )
key* -
)- .
:/ 0
base1 5
(5 6
$"6 8
$str8 A
{A B
nameB F
}F G
$strG K
{K L
keyL O
}O P
$strP c
"c d
)d e
{ 
} 
}		 ¡
WC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Exceptions\ValidationEx.cs
	namespace 	
MSschool
 
. 
Application 
. 

Exceptions )
;) *
public 
class 
ValidationEx 
:  
ApplicationException 0
{ 
public 

IDictionary 
< 
string 
, 
string %
[% &
]& '
>' (
Errors) /
{0 1
get2 5
;5 6
set7 :
;: ;
}< =
public		 

ValidationEx		 
(		 
)		 
:		 
base		  
(		  !
$str		! S
)		S T
{

 
Errors 
= 
new 

Dictionary 
<  
string  &
,& '
string( .
[. /
]/ 0
>0 1
(1 2
)2 3
;3 4
} 
public 

ValidationEx 
( 
IEnumerable #
<# $
ValidationFailure$ 5
>5 6
failures7 ?
)? @
:A B
thisC G
(G H
)H I
{ 
Errors 
= 
failures 
. 
GroupBy 
( 
e 
=> 
e 
. 
PropertyName (
,( )
e* +
=>, .
e/ 0
.0 1
ErrorMessage1 =
)= >
. 
ToDictionary 
( 
failureGroup 
=> 
failureGroup  ,
., -
Key- 0
,0 1
failureGroup 
=> 
failureGroup  ,
., -
ToArray- 4
(4 5
)5 6
)6 7
;7 8
} 
} Î
äC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\ApplicationUsers\Command\AddUserAddresses\AddUserAddressesCommand.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (
ApplicationUsers( 8
.8 9
Command9 @
.@ A
AddUserAddressesA Q
;Q R
public 
record #
AddUserAddressesCommand %
(% &
Guid 
IdUser	 
, 
string 

Country 
, 
string 

CountryCode 
, 
string		 


Department		 
,		 
string

 

DepartmentCode

 
,

 
string 

City 
, 
string 

CityCode 
, 
string 

	Direction 
) 
: 
ICommand 
; Ê 
ëC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\ApplicationUsers\Command\AddUserAddresses\AddUserAddressesCommandHandler.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (
ApplicationUsers( 8
.8 9
Command9 @
.@ A
AddUserAddressesA Q
;Q R
public

 
sealed

 
class

 *
AddUserAddressesCommandHandler

 2
:

3 4
ICommandHandler

5 D
<

D E#
AddUserAddressesCommand

E \
>

\ ]
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
ILogger 
< *
AddUserAddressesCommandHandler ;
>; <
_logger= D
;D E
public 
*
AddUserAddressesCommandHandler )
() *
IUnitOfWork* 5

unitOfWork6 @
,@ A
ILoggerB I
<I J*
AddUserAddressesCommandHandlerJ h
>h i
loggerj p
)p q
{ 
_unitOfWork 
= 

unitOfWork  
;  !
_logger 
= 
logger 
; 
} 
public 

async 
Task 
Handle 
( #
AddUserAddressesCommand 4
request5 <
,< =
CancellationToken> O
cancellationTokenP a
)a b
{ 
var 
user 
= 
await 
_unitOfWork $
. 

Repository 
< 
User 
> 
( 
) 
. 
GetByIdAsync 
( 
request !
.! "
IdUser" (
)( )
??* ,
throw- 2
new3 6
BadRequestEx7 C
(C D
$"D F
$strF L
{L M
requestM T
.T U
IdUserU [
}[ \
$str\ }
"} ~
)~ 
;	 Ä
user 
= 
User 
. 
Factory 
. 
AddPlaceOfBirth +
(+ ,
new, /
Id0 2
(2 3
request3 :
.: ;
IdUser; A
)A B
,B C
userD H
.H I
	FirstNameI R
,R S
userT X
.X Y

SecondNameY c
,c d
usere i
.i j
Surnamej q
,q r
user 
. 
Email 
, 
user 
. 
DocumentType )
,) *
user+ /
./ 0
DocumentNumber0 >
,> ?
user@ D
.D E
EmailE J
,J K
userL P
.P Q
PhoneQ V
,V W
userX \
.\ ]
	Birthdate] f
,f g
user 
. 
	CellPhone 
, 
request #
.# $
Country$ +
,+ ,
request- 4
.4 5
CountryCode5 @
,@ A
requestB I
.I J

DepartmentJ T
,T U
requestV ]
.] ^
DepartmentCode^ l
,l m
request 
. 
City 
, 
request !
.! "
CityCode" *
,* +
request, 3
.3 4
	Direction4 =
,= >
user? C
.C D
AvailabilityD P
,P Q
userR V
.V W
CreatedDateW b
)b c
;c d
await   
_unitOfWork   
.!! 

Repository!! 
<!! 
User!! 
>!! 
(!! 
)!! 
."" 
UpdateAsync"" 
("" 
user"" 
)"" 
;"" 
}## 
}$$ ˚
~C:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\ApplicationUsers\Command\CreateUser\CreateUserCommand.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (
ApplicationUsers( 8
.8 9
Command9 @
.@ A

CreateUserA K
;K L
public 
record 
CreateUserCommand 
(  
string 

	FirstName 
, 
string 


SecondName 
, 
string		 

Surname		 
,		 
string

 

SecondSurname

 
,

 
int 
DocumentType 
, 
string 

DocumentNumber 
, 
string 

Email 
, 
string 

Phone 
, 
DateTime 
	Birthdate 
, 
string 

	CellPhone 
) 
: 
ICommand  
<  !
Id! #
># $
;$ %Ÿ%
ÖC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\ApplicationUsers\Command\CreateUser\CreateUserCommandHandler.cs
	namespace		 	
MSschool		
 
.		 
Application		 
.		 
Features		 '
.		' (
ApplicationUsers		( 8
.		8 9
Command		9 @
.		@ A

CreateUser		A K
;		K L
public 
sealed 
class $
CreateUserCommandHandler ,
:- .
ICommandHandler/ >
<> ?
CreateUserCommand? P
,P Q
IdR T
>T U
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
ILogger 
< $
CreateUserCommandHandler 5
>5 6
_logger7 >
;> ?
public 
$
CreateUserCommandHandler #
(# $
IUnitOfWork$ /

unitOfWork0 :
,: ;
ILogger< C
<C D$
CreateUserCommandHandlerD \
>\ ]
logger^ d
)d e
{ 
_unitOfWork 
= 

unitOfWork  
;  !
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< 
Id 
> 
Handle  
(  !
CreateUserCommand! 2
request3 :
,: ;
CancellationToken< M
cancellationTokenN _
)_ `
{ 
var 
	existUser 
= 
await 
_unitOfWork )
.) *

Repository* 4
<4 5
User5 9
>9 :
(: ;
); <
.< =
Exitst= C
(C D
ValidatedUserD Q
(Q R
requestR Y
)Y Z
)Z [
;[ \
if 

( 
	existUser 
) 
{ 	
_logger 
. 

LogWarning 
( 
$str A
,A B
nameofC I
(I J
UserJ N
)N O
,O P
requestQ X
)X Y
;Y Z
throw 
new 
BadRequestEx "
(" #
$"# %
$str% (
{( )
nameof) /
(/ 0
User0 4
)4 5
}5 6
$str6 @
"@ A
)A B
;B C
} 	
var 
user 
= 
new 
User 
( 
new 
Id  "
(" #
Guid# '
.' (
NewGuid( /
(/ 0
)0 1
)1 2
,2 3
request4 ;
.; <
	FirstName< E
,E F
requestG N
.N O

SecondNameO Y
,Y Z
request[ b
.b c
Surnamec j
,j k
request   
.   
SecondSurname   !
,  ! "
request  # *
.  * +
DocumentType  + 7
.  7 8
ToString  8 @
(  @ A
)  A B
,  B C
request  D K
.  K L
DocumentNumber  L Z
,  Z [
request  \ c
.  c d
Email  d i
,  i j
request  k r
.  r s
Phone  s x
,  x y
request!! 
.!! 
	Birthdate!! 
,!! 
request!! &
.!!& '
	CellPhone!!' 0
)!!0 1
;!!1 2
await## 
_unitOfWork## 
.## 

Repository## $
<##$ %
User##% )
>##) *
(##* +
)##+ ,
.##, -
AddAsync##- 5
(##5 6
user##6 :
)##: ;
;##; <
return$$ 
user$$ 
.$$ 
Id$$ 
;$$ 
}%% 
private'' 
static'' 

Expression'' 
<'' 
Func'' "
<''" #
User''# '
,''' (
bool'') -
>''- .
>''. /
ValidatedUser''0 =
(''= >
CreateUserCommand''> O
request''P W
)''W X
=>''Y [
user(( 
=>(( 
user)) 
.)) 
DocumentType)) 
==)) 
request)) $
.))$ %
DocumentType))% 1
.))1 2
ToString))2 :
()): ;
))); <
&&))= ?
user** 
.** 
DocumentNumber** 
==** 
request** &
.**& '
DocumentNumber**' 5
;**5 6
}++ ”
áC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\ApplicationUsers\Command\CreateUser\CreateUserCommandValidator.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (
ApplicationUsers( 8
.8 9
Command9 @
.@ A

CreateUserA K
;K L
public 
class &
CreateUserCommandValidator '
:( )
AbstractValidator* ;
<; <
CreateUserCommand< M
>M N
{ 
public 
&
CreateUserCommandValidator %
(% &
)& '
{ 
}

 
} ≠
ÅC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\CreateCategory\CreateCategoryCommand.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
CreateCategory< J
;J K
public 
record !
CreateCategoryCommand #
(# $
string 

Name 
, 
string 

Description 
) 
: 
ICommand "
<" #
Id# %
>% &
;& '¬
ãC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\CreateCategory\CreateCategoryCommandHandler.cs.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
CreateCategory< J
;J K
public

 
sealed

 
class

 (
CreateCategoryCommandHandler

 0
:

1 2
ICommandHandler

3 B
<

B C!
CreateCategoryCommand

C X
,

X Y
Id

Z \
>

\ ]
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
ILogger 
< (
CreateCategoryCommandHandler 9
>9 :
_logger; B
;B C
public 
(
CreateCategoryCommandHandler '
(' (
IUnitOfWork( 3

unitOfWork4 >
,> ?
ILogger@ G
<G H(
CreateCategoryCommandHandlerH d
>d e
loggerf l
)l m
{ 
_unitOfWork 
= 

unitOfWork  
;  !
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< 
Id 
> 
Handle  
(  !!
CreateCategoryCommand 
request %
,% &
CancellationToken 
cancellationToken +
)+ ,
{ 
var 
existCategory 
= 
await !
_unitOfWork" -
. 

Repository 
< 
Category  
>  !
(! "
)" #
. 
Exitst 
( 
e 
=> 
e 
. 
Name 
!  
.  !
Equals! '
(' (
request( /
./ 0
Name0 4
)4 5
)5 6
;6 7
if 

( 
existCategory 
) 
{ 	
_logger 
. 

LogWarning 
( 
$str E
,E F
nameofG M
(M N
CategoryN V
)V W
,W X
requestY `
)` a
;a b
throw   
new   
BadRequestEx   "
(  " #
$"  # %
$str  % (
{  ( )
nameof  ) /
(  / 0
Category  0 8
)  8 9
}  9 :
$str  : D
"  D E
)  E F
;  F G
}!! 	
var## 
category## 
=## 
new## 
Category## #
(### $
new$$ 
Id$$ 
($$ 
Guid$$ 
.$$ 
NewGuid$$ 
($$  
)$$  !
)$$! "
,$$" #
request%% 
.%% 
Name%% 
,%% 
request&& 
.&& 
Description&& 
)&&  
;&&  !
await(( 
_unitOfWork(( 
.)) 

Repository)) 
<)) 
Category))  
>))  !
())! "
)))" #
.** 
AddAsync** 
(** 
category** 
)** 
;**  
return,, 
category,, 
.,, 
Id,, 
!,, 
;,, 
}-- 
}.. ·	
ãC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\CreateCategory\CreateCategoryCommandValidation.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
CreateCategory< J
;J K
public 
class +
CreateCategoryCommandValidation ,
:- .
AbstractValidator/ @
<@ A!
CreateCategoryCommandA V
>V W
{ 
public 
+
CreateCategoryCommandValidation *
(* +
)+ ,
{ 
RuleFor		 
(		 
r		 
=>		 
r		 
.		 
Name		 
)		 
.

 
NotEmpty

 
(

 
)

 
.

 
WithMessage

 #
(

# $
$str

$ O
)

O P
. 
Length 
( 
$num 
, 
$num 
) 
. 
WithMessage &
(& '
$str	' ò
)
ò ô
;
ô ö
} 
} Ì
ÅC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\DeleteCategory\DeleteCategoryCommand.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
DeleteCategory< J
;J K
public 
record !
DeleteCategoryCommand #
(# $
Guid$ (
Id) +
)+ ,
:- .
ICommand/ 7
<7 8
Id8 :
>: ;
;; <Ó
àC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\DeleteCategory\DeleteCategoryCommandHandler.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
DeleteCategory< J
;J K
public		 
sealed		 
class		 (
DeleteCategoryCommandHandler		 0
:		1 2
ICommandHandler		3 B
<		B C!
DeleteCategoryCommand		C X
,		X Y
Id		Z \
>		\ ]
{

 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
public 
(
DeleteCategoryCommandHandler '
(' (
IUnitOfWork( 3

unitOfWork4 >
)> ?
{ 
_unitOfWork 
= 

unitOfWork  
;  !
} 
public 

async 
Task 
< 
Id 
> 
Handle  
(  !!
DeleteCategoryCommand! 6
request7 >
,> ?
CancellationToken@ Q
cancellationTokenR c
)c d
{ 
var 
settings 
= 
new %
GetCategorySettingsParams 4
(4 5
true5 9
,9 :
request; B
.B C
IdC E
)E F
;F G
var 
spec 
= 
new 
GetCategorySpec &
(& '
settings' /
)/ 0
;0 1
var 
category 
= 
await 
_unitOfWork (
. 

Repository 
< 
Category  
>  !
(! "
)" #
. 
GetIdWithSpec 
( 
spec 
)  
??! #
throw 
new 
	Exception 
(  
$str =
)= >
;> ?
await 
_unitOfWork 
. 

Repository $
<$ %
Category% -
>- .
(. /
)/ 0
.0 1
DeleteAsync1 <
(< =
category= E
)E F
;F G
return 
category 
. 
Id 
; 
}   
}!! ã
ãC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\DeleteCategory\DeleteCategoryCommandValidation.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
DeleteCategory< J
{ 
internal		 
class		 +
DeleteCategoryCommandValidation		 2
{

 
} 
} ﬁ
ÅC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\UpdateCategory\UpdateCategoryCommand.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
UpdateCategory< J
;J K
public 
record !
UpdateCategoryCommand #
(# $
Guid 
Id	 
, 
string 

Name 
, 
string		 

Description		 
)		 
:		 
ICommand		 "
<		" #
Id		# %
>		% &
;		& 'é
àC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\UpdateCategory\UpdateCategoryCommandHandler.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
UpdateCategory< J
;J K
public

 
class

 (
UpdateCategoryCommandHandler

 )
:

* +
ICommandHandler

, ;
<

; <!
UpdateCategoryCommand

< Q
,

Q R
Id

S U
>

U V
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
public 
(
UpdateCategoryCommandHandler '
(' (
IUnitOfWork( 3

unitOfWork4 >
)> ?
{ 
_unitOfWork 
= 

unitOfWork  
;  !
} 
public 

async 
Task 
< 
Id 
> 
Handle  
(  !!
UpdateCategoryCommand! 6
request7 >
,> ?
CancellationToken@ Q
cancellationTokenR c
)c d
{ 
var 
category 
= 
await 
_unitOfWork (
. 

Repository 
< 
Category  
>  !
(! "
)" #
. 
GetByIdAsync 
( 
request !
.! "
Id" $
)$ %
??& (
throw 
new 
BadRequestEx "
(" #
$str ?
)? @
;@ A
category 
= 
Category 
. 
Factory #
. 
Update 
( 
new 
Id 
( 
request "
." #
Id# %
)% &
,& '
new( +
Name, 0
(0 1
request1 8
.8 9
Name9 =
)= >
,> ?
request@ G
.G H
DescriptionH S
,S T
categoryU ]
.] ^
Availability^ j
,j k
categoryl t
.t u
CreatedDate	u Ä
)
Ä Å
;
Å Ç
await 
_unitOfWork 
. 

Repository $
<$ %
Category% -
>- .
(. /
)/ 0
.0 1
UpdateAsync1 <
(< =
category= E
)E F
;F G
return   
category   
.   
Id   
!   
;   
}!! 
}"" Û
ÉC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Commands\UpdateCategory\UpdateCommandValidation.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Commands3 ;
.; <
UpdateCategory< J
;J K
public 
class #
UpdateCommandValidation $
:% &
AbstractValidator' 8
<8 9!
UpdateCategoryCommand9 N
>N O
{ 
public 
#
UpdateCommandValidation "
(" #
)# $
{ 
RuleFor		 
(		 
r		 
=>		 
r		 
.		 
Id		 
)		 
.

 
NotEmpty

 
(

 
)

 
.

 
WithMessage

 #
(

# $
$str

$ K
)

K L
;

L M
RuleFor 
( 
r 
=> 
r 
. 
Name 
) 
. 
NotEmpty 
( 
) 
. 
WithMessage #
(# $
$str$ O
)O P
. 
Length 
( 
$num 
, 
$num 
) 
. 
WithMessage &
(& '
$str	' ò
)
ò ô
;
ô ö
} 
} “
ÄC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Queries\GetCategoryById\GetCategoryByIdQuery.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Queries3 :
.: ;
GetCategoryById; J
;J K
public 
record 
class  
GetCategoryByIdQuery (
(( )
Guid) -
Id. 0
,0 1
bool2 6
IgnoreQueryFilters7 I
)I J
:K L
IQueryM S
<S T#
GetCategoryByIdResponseT k
>k l
;l m¢
áC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Queries\GetCategoryById\GetCategoryByIdQueryHandler.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Queries3 :
.: ;
GetCategoryById; J
;J K
public

 
sealed

 
class

 '
GetCategoryByIdQueryHandler

 /
:

0 1
IQueryHandler

2 ?
<

? @ 
GetCategoryByIdQuery

@ T
,

T U#
GetCategoryByIdResponse

V m
>

m n
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
private 
readonly 
ILogger 
< '
GetCategoryByIdQueryHandler 8
>8 9
_logger: A
;A B
public 
'
GetCategoryByIdQueryHandler &
(& '
IUnitOfWork' 2

unitOfWork3 =
,= >
ILogger? F
<F G'
GetCategoryByIdQueryHandlerG b
>b c
loggerd j
)j k
{ 
_unitOfWork 
= 

unitOfWork  
;  !
_logger 
= 
logger 
; 
} 
public 

async 
Task 
< #
GetCategoryByIdResponse -
>- .
Handle/ 5
(5 6 
GetCategoryByIdQuery6 J
requestK R
,R S
CancellationTokenT e
cancellationTokenf w
)w x
{ 
var 
settings 
= 
new %
GetCategorySettingsParams 4
(4 5
request 
. 
IgnoreQueryFilters &
,& '
request 
. 
Id 
) 
; 
var 
spec 
= 
new 
GetCategorySpec &
(& '
settings' /
)/ 0
;0 1
var 
category 
= 
await 
_unitOfWork (
. 

Repository 
< 
Category  
>  !
(! "
)" #
.   
GetIdWithSpec   
(   
spec   
)    
??  ! #
throw!! 
new!! 
	Exception!! 
(!!  
$str"" L
)""L M
;""M N
var$$ 
result$$ 
=$$ 
new$$ #
GetCategoryByIdResponse$$ 0
($$0 1
category%% 
.%% 
Id%% 
!%% 
.%% 
Value%% 
!%% 
,%%  
category&& 
.&& 
Name&& 
,&& 
category'' 
.'' 
Description''  
)''  !
;''! "
return)) 
result)) 
;)) 
}** 
}++ ¿
ÉC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Queries\GetCategoryById\GetCategoryByIdResponse.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Queries3 :
.: ;
GetCategoryById; J
;J K
public 
record 
class #
GetCategoryByIdResponse +
(+ ,
Guid, 0
Id1 3
,3 4
string5 ;
?; <
Name= A
,A B
stringC I
?I J
DescriptionK V
)V W
;W XÃ
àC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Queries\PagGetAllCategories\PagGetAllCategoriesQuery.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Queries3 :
.: ;
PagGetAllCategories; N
;N O
public 
class $
PagGetAllCategoriesQuery %
:& '
PaginationBaseQuery( ;
,; <
ICommand= E
<E F
PaginationResponseF X
<X Y'
PagGetAllCategoriesResponseY t
>t u
>u v
{ 
} œ)
èC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Queries\PagGetAllCategories\PagGetAllCategoriesQueryHandler.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Queries3 :
.: ;
PagGetAllCategories; N
;N O
public		 
sealed		 
class		 +
PagGetAllCategoriesQueryHandler		 3
:		4 5
ICommandHandler

 
<

 $
PagGetAllCategoriesQuery

 ,
,

, -
PaginationResponse

. @
<

@ A'
PagGetAllCategoriesResponse

A \
>

\ ]
>

] ^
{ 
private 
readonly 
IUnitOfWork  
_unitOfWork! ,
;, -
public 
+
PagGetAllCategoriesQueryHandler *
(* +
IUnitOfWork+ 6

unitOfWork7 A
)A B
{ 
_unitOfWork 
= 

unitOfWork  
;  !
} 
public 

async 
Task 
< 
PaginationResponse (
<( )'
PagGetAllCategoriesResponse) D
>D E
>E F
HandleG M
(M N$
PagGetAllCategoriesQuery  
request! (
,( )
CancellationToken* ;
cancellationToken< M
)M N
{ 
var 
settingsParams 
= 
new  -
!PagGetAllCategoriesSettingsParams! B
(B C
)C D
{ 	
	PageIndex 
= 
request 
.  
	PageIndex  )
,) *
PageSize 
= 
request 
. 
PageSize '
,' (
Search 
= 
request 
. 
Search #
,# $
Sort 
= 
request 
. 
Sort 
,   
DisableGlobalFilters  
=! "
request# *
.* + 
DisableGlobalFilters+ ?
} 	
;	 

var 
getAllWithSpec 
= 
new  ,
 PagGetAllCategoriesSpecification! A
(A B
settingsParamsB P
)P Q
;Q R
var   

categories   
=   
await   
_unitOfWork   *
.!! 

Repository!! 
<!! 
Category!!  
>!!  !
(!!! "
)!!" #
."" 
GetAllWithSpec"" 
("" 
getAllWithSpec"" *
)""* +
;""+ ,
var$$ 
	countSpec$$ 
=$$ 
new$$ *
PagGetAllCategoriesCounterSpec$$ :
($$: ;
settingsParams$$; I
)$$I J
;$$J K
var%% 
totalCategories%% 
=%% 
await%% #
_unitOfWork%%$ /
.&& 

Repository&& 
<&& 
Category&&  
>&&  !
(&&! "
)&&" #
.'' 

CountAsync'' 
('' 
	countSpec'' !
)''! "
;''" #
var)) 
rounded)) 
=)) 
Math)) 
.** 
Ceiling** 
(** 
Convert** 
.** 
	ToDecimal** &
(**& '
totalCategories**' 6
)**6 7
/**8 9
Convert**: A
.**A B
	ToDecimal**B K
(**K L
request**L S
.**S T
PageSize**T \
)**\ ]
)**] ^
;**^ _
var++ 

totalPages++ 
=++ 
Convert++  
.++  !
ToInt32++! (
(++( )
rounded++) 0
)++0 1
;++1 2
var-- 
data-- 
=-- 

categories-- 
.-- 
Select-- $
(--$ %
category--% -
=>--. 0
new.. '
PagGetAllCategoriesResponse.. '
(..' (
category// 
!// 
.// 
Id// 
.// 
Value// 
,// 
category00 
!00 
.00 
Name00 
!00 
,00 
category11 
!11 
.11 
Description11 !
!11! "
)11" #
)11# $
.22 
ToList22 
(22 
)22 
;22 
var44 
result44 
=44 
new44 
PaginationResponse44 +
<44+ ,'
PagGetAllCategoriesResponse44, G
>44G H
(44H I
)44I J
{55 	
Count66 
=66 
totalCategories66 #
,66# $
Data77 
=77 
data77 
,77 
	PageCount88 
=88 

totalPages88 "
,88" #
	PageIndex99 
=99 
request99 
.99  
	PageIndex99  )
,99) *
PageSize:: 
=:: 
request:: 
.:: 
PageSize:: '
};; 	
;;;	 

return== 
result== 
;== 
}>> 
}?? ü
ãC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Features\Categories\Queries\PagGetAllCategories\PagGetAllCategoriesResponse.cs
	namespace 	
MSschool
 
. 
Application 
. 
Features '
.' (

Categories( 2
.2 3
Queries3 :
.: ;
PagGetAllCategories; N
;N O
public 
record '
PagGetAllCategoriesResponse )
() *
Guid 
Id	 
, 
string 

Name 
, 
string 

Description 
) 
; Ò
\C:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Handlers\PagApiMinimalHelper.cs
	namespace 	
MSschool
 
. 
Application 
. 
Handlers '
;' (
public 
record 
class 
PagApiMinimalHelper '
(' (
string( .
Sort/ 3
,3 4
string5 ;
Search< B
,B C
intD G
	PageIndexH Q
,Q R
intS V
PageSizeW _
)_ `
{ 
public		 

static		 
	ValueTask		 
<		 
PagApiMinimalHelper		 /
?		/ 0
>		0 1
	BindAsync		2 ;
(		; <
HttpContext

 
context

 
,

 
ParameterInfo 
	parameter 
)  
{ 
if 

( 
	parameter 
is 
null 
) 
{ 	
throw 
new !
ArgumentNullException +
(+ ,
nameof, 2
(2 3
	parameter3 <
)< =
)= >
;> ?
} 	
string 
sort 
= 
context 
. 
Request 
. 
Query 
[ !
PaginationHandlerKeys (
.( )
sortkey) 0
]0 1
!1 2
;2 3
string 
search 
= 
context 
. 
Request 
. 
Query 
[ !
PaginationHandlerKeys (
.( )
	searchkey) 2
]2 3
!3 4
;4 5
_ 	
=
 
int 
. 
TryParse 
( 
context 
. 
Request 
. 
Query !
[! "!
PaginationHandlerKeys" 7
.7 8
pageindexkey8 D
]D E
,E F
out 
var 
	pageIndex 
) 
; 
	pageIndex 
= 
	pageIndex 
==  
$num! "
?# $
$num% &
:' (
	pageIndex) 2
;2 3
_   	
=  
 
int   
.   
TryParse   
(   
context!! 
.!! 
Request!! 
.!! 
Query!! !
[!!! "!
PaginationHandlerKeys!!" 7
.!!7 8
pagesizekey!!8 C
]!!C D
,!!D E
out"" 
var"" 
pagesize"" 
)"" 
;"" 
pagesize$$ 
=$$ 
pagesize$$ 
==$$ 
$num$$  
?$$! "
$num$$# $
:$$% &
pagesize$$' /
;$$/ 0
var&& 
result&& 
=&& 
new&& 
PagApiMinimalHelper&& ,
(&&, -
sort'' 
,'' 
search'' 
,'' 
	pageIndex'' #
,''# $
pagesize''% -
)''- .
;''. /
return)) 
	ValueTask)) 
.)) 

FromResult)) #
<))# $
PagApiMinimalHelper))$ 7
?))7 8
>))8 9
())9 :
result)): @
)))@ A
;))A B
}** 
}++ 
XC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Models\ConnectionStrings.cs
	namespace 	
MSschool
 
. 
Application 
. 
Models %
;% &
public 
class 
ConnectionStrings 
{ 
public 

string 
? 
ConnectionString #
{$ %
get& )
;) *
set+ .
;. /
}0 1
} ä
tC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Specifications\GetCategory\GetCategorySettingsParams.cs
	namespace 	
MSschool
 
. 
Application 
. 
Specifications -
.- .
GetCategory. 9
;9 :
public 
record %
GetCategorySettingsParams '
(' (
bool( , 
DisableGlobalFilters- A
,A B
GuidC G
IdH J
)J K
;K L¥
jC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Specifications\GetCategory\GetCategorySpec.cs
	namespace 	
MSschool
 
. 
Application 
. 
Specifications -
.- .
GetCategory. 9
;9 :
internal 
class	 
GetCategorySpec 
:  
BaseSpecification! 2
<2 3
Category3 ;
>; <
{ 
public		 

GetCategorySpec		 
(		 %
GetCategorySettingsParams		 4
settings		5 =
)		= >
:		? @
base

 
(

 
bs

 
=>

 
bs

 
.

 
Id

 
==

 
new

 
Id

  "
(

" #
settings

# +
.

+ ,
Id

, .
)

. /
)

/ 0
{ !
AddIgnoreQueryFilters 
( 
settings &
.& ' 
DisableGlobalFilters' ;
); <
;< =
} 
} ¶

ÅC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Specifications\PagGetAllCategories\PagGetAllCategoriesCounterSpec.cs
	namespace 	
MSschool
 
. 
Application 
. 
Specifications -
.- .
PagGetAllCategories. A
;A B
public 
class *
PagGetAllCategoriesCounterSpec +
:, -
BaseSpecification. ?
<? @
Category@ H
>H I
{ 
public 
*
PagGetAllCategoriesCounterSpec )
() *-
!PagGetAllCategoriesSettingsParams* K
settingsL T
)T U
:V W
base		 
(		 
bs		 
=>		 
string		 
.		 
IsNullOrEmpty		 '
(		' (
settings		( 0
.		0 1
Search		1 7
)		7 8
||		9 ;
bs		< >
.		> ?
Name		? C
!		C D
.		D E
Contains		E M
(		M N
settings		N V
.		V W
Search		W ]
)		] ^
)		^ _
{

 !
AddIgnoreQueryFilters 
( 
settings &
.& ' 
DisableGlobalFilters' ;
); <
;< =
} 
} ‚
ÑC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Specifications\PagGetAllCategories\PagGetAllCategoriesSettingsParams.cs
	namespace 	
MSschool
 
. 
Application 
. 
Specifications -
.- .
PagGetAllCategories. A
;A B
public 
class -
!PagGetAllCategoriesSettingsParams .
:/ 0
SpecificationParams1 D
{ 
}  
ÉC:\Users\Jhonatan\source\repos\msschool\MSschool.Application\Specifications\PagGetAllCategories\PagGetAllCategoriesSpecification.cs
	namespace 	
MSschool
 
. 
Application 
. 
Specifications -
.- .
PagGetAllCategories. A
;A B
public 
sealed 
class ,
 PagGetAllCategoriesSpecification 4
:5 6
BaseSpecification7 H
<H I
CategoryI Q
>Q R
{ 
public		 
,
 PagGetAllCategoriesSpecification		 +
(		+ ,-
!PagGetAllCategoriesSettingsParams		, M
settings		N V
)		V W
:		X Y
base

 
(

 
bs

 
=>

 
string

 
.

 
IsNullOrEmpty

 '
(

' (
settings

( 0
.

0 1
Search

1 7
)

7 8
||

9 ;
bs

< >
.

> ?
Name

? C
!

C D
.

D E
Contains

E M
(

M N
settings

N V
.

V W
Search

W ]
)

] ^
)

^ _
{ 
ApplyPaging 
( 
settings 
. 
PageSize %
*& '
(( )
settings) 1
.1 2
	PageIndex2 ;
-< =
$num> ?
)? @
,@ A
settingsB J
.J K
PageSizeK S
)S T
;T U
if 

( 
! 
string 
. 
IsNullOrEmpty !
(! "
settings" *
.* +
Sort+ /
)/ 0
)0 1
{ 	
switch 
( 
settings 
. 
Sort !
)! "
{ 
case 
CategoryOrdering %
.% &
nameAsc& -
:- .

AddOrderBy 
( 
x  
=>! #
x$ %
.% &
Name& *
)* +
;+ ,
break 
; 
case 
CategoryOrdering %
.% &
nameDesc& .
:. /
AddOrderByDesc "
(" #
x# $
=>% '
x( )
.) *
Name* .
). /
;/ 0
break 
; 
case 
CategoryOrdering %
.% &
idAsc& +
:+ ,

AddOrderBy 
( 
x  
=>! #
x$ %
.% &
Id& (
)( )
;) *
break 
; 
case 
CategoryOrdering %
.% &
idDesc& ,
:, -
AddOrderByDesc "
(" #
x# $
=>% '
x( )
.) *
Id* ,
), -
;- .
break   
;   
default"" 
:"" 

AddOrderBy## 
(## 
x##  
=>##! #
x##$ %
.##% &
Name##& *
)##* +
;##+ ,
break$$ 
;$$ 
}%% 
}&& 	!
AddIgnoreQueryFilters(( 
((( 
settings(( &
.((& ' 
DisableGlobalFilters((' ;
)((; <
;((< =
})) 
}** 