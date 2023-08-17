Þ
iC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\AddCategory.cs
	namespace		 	
MSschool		
 
.		 
Presentation		 
.		  
	Endpoints		  )
.		) *
	Endpoints		* 3
.		3 4
Category		4 <
;		< =
internal 
static	 
class 
AddCategory !
{ 
internal 
static 
void 
Endpoint !
(! "
RouteGroupBuilder" 3
category4 <
)< =
{ 
category 
. 
MapPost 
( 
$str 
,  
AddCategory! ,
), -
. 
WithOpenApi 
( 
generatedOperation +
=>, .
new/ 2
(2 3
generatedOperation3 E
)E F
{ 
OperationId 
= 
$str +
,+ ,
Tags 
= 
new 
List 
<  

OpenApiTag  *
>* +
(+ ,
), -
{. /
new0 3

OpenApiTag4 >
{? @
NameA E
=F G
$strH R
}S T
}U V
,V W
Summary 
= 
$str L
,L M
Description 
= 
$str 5
} 
) 
. 
Produces 
< !
CreateCategoryCommand +
>+ ,
(, -
StatusCodes- 8
.8 9
Status200OK9 D
)D E
. 
Produces 
( 
StatusCodes !
.! "
Status400BadRequest" 5
)5 6
. 
Accepts 
< !
CreateCategoryCommand *
>* +
(+ ,
$str, >
)> ?
;? @
static 
async 
Task 
< 
IResult !
>! "
AddCategory# .
(. /!
CreateCategoryCommand/ D
commandE L
,L M
ISenderN U
senderV \
)\ ]
{ 	
var 
result 
= 
await 
sender %
.% &
Send& *
(* +
command+ 2
)2 3
;3 4
return 
TypedResults 
.  
Ok  "
(" #
result# )
)) *
;* +
} 	
}   
}!! ô
oC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\AllActiveCategory.cs
	namespace		 	
MSschool		
 
.		 
Presentation		 
.		  
	Endpoints		  )
.		) *
	Endpoints		* 3
.		3 4
Category		4 <
;		< =
internal 
static	 
class 
AllActiveCategory '
{ 
internal 
static 
void 
Endpoint !
(! "
RouteGroupBuilder" 3
category4 <
)< =
{ 
category 
. 
MapGet 
( 
$str #
,# $
	AllActive% .
). /
. 
WithOpenApi 
( 
generatedOperation +
=>, .
new/ 2
(2 3
generatedOperation3 E
)E F
{ 
OperationId 
= 
$str )
,) *
Tags 
= 
new 
List 
<  

OpenApiTag  *
>* +
(+ ,
), -
{. /
new0 3

OpenApiTag4 >
{? @
NameA E
=F G
$strH R
}S T
}U V
,V W
Summary 
= 
$str V
,V W
Description 
= 
$str 5
} 
) 
. 
Produces 
< '
PagGetAllCategoriesResponse 1
>1 2
(2 3
StatusCodes3 >
.> ?
Status200OK? J
)J K
. 
Produces 
( 
StatusCodes !
.! "
Status400BadRequest" 5
)5 6
;6 7
static 
async 
Task 
< 
IResult !
>! "
	AllActive# ,
(, -
PagApiMinimalHelper- @
queryA F
,F G
ISenderH O
senderP V
)V W
{ 	
var 

categories 
= 
new  $
PagGetAllCategoriesQuery! 9
(9 :
): ;
{   
	PageIndex!! 
=!! 
query!! !
.!!! "
	PageIndex!!" +
,!!+ ,
PageSize"" 
="" 
query""  
.""  !
PageSize""! )
,"") *
Search## 
=## 
query## 
.## 
Search## %
,##% &
Sort$$ 
=$$ 
query$$ 
.$$ 
Sort$$ !
,$$! " 
DisableGlobalFilters%% $
=%%% &
false%%' ,
}&& 
;&& 
var(( 
result(( 
=(( 
await(( 
sender(( %
.((% &
Send((& *
(((* +

categories((+ 5
)((5 6
;((6 7
return)) 
Results)) 
.)) 
Ok)) 
()) 
result)) $
)))$ %
;))% &
}** 	
}++ 
},, Ÿ
zC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\AllIncludingInactiveCategory.cs
	namespace		 	
MSschool		
 
.		 
Presentation		 
.		  
	Endpoints		  )
.		) *
	Endpoints		* 3
.		3 4
Category		4 <
;		< =
internal 
static	 
class (
AllIncludingInactiveCategory 2
{ 
internal 
static 
void 
Endpoint !
(! "
RouteGroupBuilder" 3
category4 <
)< =
{ 
category 
. 
MapGet 
( 
$str .
,. / 
AllIncludingInactive0 D
)D E
. 
WithOpenApi 
( 
generatedOperation +
=>, .
new/ 2
(2 3
generatedOperation3 E
)E F
{ 
OperationId 
= 
$str 4
,4 5
Tags 
= 
new 
List 
<  

OpenApiTag  *
>* +
(+ ,
), -
{. /
new0 3

OpenApiTag4 >
{? @
NameA E
=F G
$strH R
}S T
}U V
,V W
Summary 
= 
$str g
,g h
Description 
= 
$str 5
} 
) 
. 
Produces 
< '
PagGetAllCategoriesResponse 1
>1 2
(2 3
StatusCodes3 >
.> ?
Status200OK? J
)J K
. 
Produces 
( 
StatusCodes !
.! "
Status400BadRequest" 5
)5 6
;6 7
static 
async 
Task 
< 
IResult !
>! " 
AllIncludingInactive# 7
(7 8
PagApiMinimalHelper8 K
queryL Q
,Q R
ISenderS Z
sender[ a
)a b
{ 	
var 

categories 
= 
new  $
PagGetAllCategoriesQuery! 9
(9 :
): ;
{ 
	PageIndex 
= 
query !
.! "
	PageIndex" +
,+ ,
PageSize 
= 
query  
.  !
PageSize! )
,) *
Search   
=   
query   
.   
Search   %
,  % &
Sort!! 
=!! 
query!! 
.!! 
Sort!! !
,!!! " 
DisableGlobalFilters"" $
=""% &
true""' +
}## 
;## 
var%% 
result%% 
=%% 
await%% 
sender%% %
.%%% &
Send%%& *
(%%* +

categories%%+ 5
)%%5 6
;%%6 7
return&& 
Results&& 
.&& 
Ok&& 
(&& 
result&& $
)&&$ %
;&&% &
}'' 	
}(( 
})) ¸
lC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\DeleteCategory.cs
	namespace 	
MSschool
 
. 
Presentation 
.  
	Endpoints  )
.) *
	Endpoints* 3
.3 4
Category4 <
;< =
internal

 
static

	 
class

 
DeleteCategory

 $
{ 
internal 
static 
void 
Endpoint !
(! "
RouteGroupBuilder" 3
category4 <
)< =
{ 
category 
. 
	MapDelete 
( 
$str (
,( )
DeleteCategory* 8
)8 9
. 
WithOpenApi 
( 
generatedOperation +
=>, .
new/ 2
(2 3
generatedOperation3 E
)E F
{ 
OperationId 
= 
$str &
,& '
Tags 
= 
new 
List 
<  

OpenApiTag  *
>* +
(+ ,
), -
{. /
new0 3

OpenApiTag4 >
{? @
NameA E
=F G
$strG Q
}Q R
}S T
,T U
Summary 
= 
$str @
,@ A
Description 
= 
$str 3
} 
) 
; 
static 
async 
Task 
< 
IResult !
>! "
DeleteCategory# 1
(1 2
Guid2 6
id7 9
,9 :
ISender; B
senderC I
)I J
{ 	
var 
result 
= 
await 
sender %
.% &
Send& *
(* +
new+ .!
DeleteCategoryCommand/ D
(D E
idE G
)G H
)H I
;I J
return 
Results 
. 
Ok 
( 
result $
)$ %
;% &
} 	
} 
} ‚
|C:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\EndpointsConfigurationCategory.cs
	namespace 	
MSschool
 
. 
Presentation 
.  
	Endpoints  )
.) *
	Endpoints* 3
.3 4
Category4 <
;< =
public 
class *
EndpointsConfigurationCategory +
:, -
ICarterModule. ;
{ 
public		 

void		 
	AddRoutes		 
(		 !
IEndpointRouteBuilder		 /
app		0 3
)		3 4
{

 
var 
category 
= 
app 
. 
MapGroup #
(# $
$str$ /
)/ 0
;0 1
AddCategory 
. 
Endpoint 
( 
category %
)% &
;& '
UpdateCategory 
. 
Endpoint 
(  
category  (
)( )
;) *
AllActiveCategory 
. 
Endpoint "
(" #
category# +
)+ ,
;, -(
AllIncludingInactiveCategory $
.$ %
Endpoint% -
(- .
category. 6
)6 7
;7 8!
GetActiveByIdCategory 
. 
Endpoind &
(& '
category' /
)/ 0
;0 1
DeleteCategory 
. 
Endpoint 
(  
category  (
)( )
;) *,
 GetIncludingInactiveByIdCategory (
.( )
Endpoind) 1
(1 2
category2 :
): ;
;; <
} 
} Š
sC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\GetActiveByIdCategory.cs
	namespace		 	
MSschool		
 
.		 
Presentation		 
.		  
	Endpoints		  )
.		) *
	Endpoints		* 3
.		3 4
Category		4 <
;		< =
internal 
class	 !
GetActiveByIdCategory $
{ 
internal 
static 
void 
Endpoind !
(! "
RouteGroupBuilder" 3
category4 <
)< =
{ 
category 
. 
MapGet 
( 
$str ,
,, -!
GetActiveCategoryById. C
)C D
. 
WithOpenApi 
( 
generatedOperation +
=>, .
new/ 2
(2 3
generatedOperation3 E
)E F
{ 
OperationId 
= 
$str -
,- .
Tags 
= 
new 
List 
<  

OpenApiTag  *
>* +
(+ ,
), -
{. /
new0 3

OpenApiTag4 >
{? @
NameA E
=F G
$strH R
}S T
}U V
,V W
Summary 
= 
$str U
,U V
Description 
= 
$str 5
} 
) 
. 
Produces 
< '
PagGetAllCategoriesResponse 1
>1 2
(2 3
StatusCodes3 >
.> ?
Status200OK? J
)J K
. 
Produces 
( 
StatusCodes !
.! "
Status400BadRequest" 5
)5 6
;6 7
static 
async 
Task 
< 
IResult !
>! "!
GetActiveCategoryById# 8
(8 9
Guid9 =
id> @
,@ A
ISenderB I
senderJ P
)P Q
{ 	
var 
query 
= 
new  
GetCategoryByIdQuery 0
(0 1
id1 3
,3 4
false5 :
): ;
;; <
var 
result 
= 
await 
sender %
.% &
Send& *
(* +
query+ 0
)0 1
;1 2
return 
Results 
. 
Ok 
( 
result $
)$ %
;% &
} 	
}   
}!! Ÿ
~C:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\GetIncludingInactiveByIdCategory.cs
	namespace		 	
MSschool		
 
.		 
Presentation		 
.		  
	Endpoints		  )
.		) *
	Endpoints		* 3
.		3 4
Category		4 <
;		< =
internal 
class	 ,
 GetIncludingInactiveByIdCategory /
{ 
internal 
static 
void 
Endpoind !
(! "
RouteGroupBuilder" 3
category4 <
)< =
{ 
category 
. 
MapGet 
( 
$str ?
,? @!
GetActiveCategoryByIdA V
)V W
. 
WithOpenApi 
( 
generatedOperation +
=>, .
new/ 2
(2 3
generatedOperation3 E
)E F
{ 
OperationId 
= 
$str @
,@ A
Tags 
= 
new 
List 
<  

OpenApiTag  *
>* +
(+ ,
), -
{. /
new0 3

OpenApiTag4 >
{? @
NameA E
=F G
$strH R
}S T
}U V
,V W
Summary 
= 
$str U
,U V
Description 
= 
$str 5
} 
) 
. 
Produces 
< '
PagGetAllCategoriesResponse 1
>1 2
(2 3
StatusCodes3 >
.> ?
Status200OK? J
)J K
. 
Produces 
( 
StatusCodes !
.! "
Status400BadRequest" 5
)5 6
;6 7
static 
async 
Task 
< 
IResult !
>! "!
GetActiveCategoryById# 8
(8 9
Guid9 =
id> @
,@ A
ISenderB I
senderJ P
)P Q
{ 	
var 
query 
= 
new  
GetCategoryByIdQuery 0
(0 1
id1 3
,3 4
true5 9
)9 :
;: ;
var 
result 
= 
await 
sender %
.% &
Send& *
(* +
query+ 0
)0 1
;1 2
return 
Results 
. 
Ok 
( 
result $
)$ %
;% &
} 	
}   
}!! ä
lC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\Category\UpdateCategory.cs
	namespace		 	
MSschool		
 
.		 
Presentation		 
.		  
	Endpoints		  )
.		) *
	Endpoints		* 3
.		3 4
Category		4 <
;		< =
internal 
static	 
class 
UpdateCategory $
{ 
internal 
static 
void 
Endpoint !
(! "
RouteGroupBuilder" 3
category4 <
)< =
{ 
category 
. 
MapPut 
( 
$str !
,! "
UpdateCategory# 1
)1 2
. 
WithOpenApi 
( 
generatedOperation +
=>, .
new/ 2
(2 3
generatedOperation3 E
)E F
{ 
OperationId 
= 
$str &
,& '
Tags 
= 
new 
List 
<  

OpenApiTag  *
>* +
(+ ,
), -
{. /
new0 3

OpenApiTag4 >
{? @
NameA E
=F G
$strH R
}S T
}U V
,V W
Summary 
= 
$str K
,K L
Description 
= 
$str 5
} 
) 
. 
Produces 
< !
UpdateCategoryCommand +
>+ ,
(, -
StatusCodes- 8
.8 9
Status200OK9 D
)D E
. 
Produces 
( 
StatusCodes !
.! "
Status400BadRequest" 5
)5 6
. 
Accepts 
< !
UpdateCategoryCommand *
>* +
(+ ,
$str, >
)> ?
;? @
static 
async 
Task 
< 
IResult !
>! "
UpdateCategory# 1
(1 2!
UpdateCategoryCommand2 G
commandH O
,O P
ISenderQ X
senderY _
)_ `
{ 	
var 
result 
= 
await 
sender %
.% &
Send& *
(* +
command+ 2
)2 3
;3 4
return 
Results 
. 
Ok 
( 
result $
)$ %
;% &
} 	
}   
}!! Ì
aC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\User\AddUser.cs
	namespace		 	
MSschool		
 
.		 
Presentation		 
.		  
	Endpoints		  )
.		) *
	Endpoints		* 3
.		3 4
User		4 8
;		8 9
internal 
static	 
class 
AddUser 
{ 
internal 
static 
void 
Endpoint !
(! "
RouteGroupBuilder" 3
routeGroupBuilder4 E
)E F
{ 
routeGroupBuilder 
. 
MapPost !
(! "
$str" (
,( )
AddUser* 1
)1 2
. 	
WithOpenApi	 
( 
generatedOperation '
=>( *
new+ .
(. /
generatedOperation/ A
)A B
{ 	
OperationId 
= 
$str #
,# $
Tags 
= 
new 
List 
< 

OpenApiTag &
>& '
(' (
)( )
{* +
new, /

OpenApiTag0 :
{; <
Name= A
=B C
$strD J
}K L
}M N
,N O
Summary 
= 
$str @
,@ A
Description 
= 
$str 1
} 	
)	 

. 	
Produces	 
< 
CreateUserCommand #
># $
($ %
StatusCodes% 0
.0 1
Status200OK1 <
)< =
. 	
Produces	 
( 
StatusCodes 
. 
Status400BadRequest 1
)1 2
. 	
Accepts	 
< 
CreateUserCommand "
>" #
(# $
$str$ 6
)6 7
;7 8
static 
async 
Task 
< 
IResult !
>! "
AddUser# *
(* +
CreateUserCommand+ <
command= D
,D E
ISenderF M
senderN T
)T U
{ 	
var 
result 
= 
await 
sender %
.% &
Send& *
(* +
command+ 2
)2 3
;3 4
return 
TypedResults 
.  
Ok  "
(" #
result# )
)) *
;* +
} 	
}   
}!! Ó
mC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\User\AddUserPlaceOfBirth.cs
	namespace 	
MSschool
 
. 
Presentation 
.  
	Endpoints  )
.) *
	Endpoints* 3
.3 4
User4 8
;8 9
internal

 
static

	 
class

 
AddUserPlaceOfBirth

 )
{ 
internal 
static 
void 
Endpoint !
(! "
RouteGroupBuilder" 3
routeGroupBuilder4 E
)E F
{ 
routeGroupBuilder 
. 
MapPut  
(  !
$str! 7
,7 8
AddUserPlaceOfBirth9 L
)L M
. 	
WithOpenApi	 
( 
generatedOperation '
=>( *
new+ .
(. /
generatedOperation/ A
)A B
{ 	
OperationId 
= 
$str /
,/ 0
Tags 
= 
new 
List 
< 

OpenApiTag &
>& '
(' (
)( )
{* +
new, /

OpenApiTag0 :
{; <
Name= A
=B C
$strD J
}K L
}M N
,N O
Summary 
= 
$str _
,_ `
Description 
= 
$str 1
} 	
)	 

. 	
Produces	 
< #
AddUserAddressesCommand )
>) *
(* +
StatusCodes+ 6
.6 7
Status204NoContent7 I
)I J
. 	
Produces	 
( 
StatusCodes 
. 
Status400BadRequest 1
)1 2
. 	
Accepts	 
< #
AddUserAddressesCommand (
>( )
() *
$str* <
)< =
;= >
static 
async 
Task 
< 
IResult !
>! "
AddUserPlaceOfBirth# 6
(6 7#
AddUserAddressesCommand7 N
commandO V
,V W
ISenderX _
sender` f
)f g
{ 	
await 
sender 
. 
Send 
( 
command %
)% &
;& '
return 
TypedResults 
.  
	NoContent  )
() *
)* +
;+ ,
} 	
} 
}   ©
tC:\Users\Jhonatan\source\repos\msschool\MSschool.Presentation.Endpoints\Endpoints\User\EndpointsConfigurationUser.cs
	namespace

 	
MSschool


 
.

 
Presentation

 
.

  
	Endpoints

  )
.

) *
	Endpoints

* 3
.

3 4
User

4 8
;

8 9
public 
class &
EndpointsConfigurationUser '
:( )
ICarterModule* 7
{ 
public 

void 
	AddRoutes 
( !
IEndpointRouteBuilder /
app0 3
)3 4
{ 
var 
user 
= 
app 
. 
MapGroup 
(  
$str  '
)' (
;( )
AddUser 
. 
Endpoint 
( 
user 
) 
; 
AddUserPlaceOfBirth 
. 
Endpoint $
($ %
user% )
)) *
;* +
} 
} 