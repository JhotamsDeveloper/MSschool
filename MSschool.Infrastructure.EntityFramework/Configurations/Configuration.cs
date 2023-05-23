using Microsoft.EntityFrameworkCore;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal static class Configuration
{
    internal static void Settings(this ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(
            typeof(AcademicLevelConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(AcademicProgramUserConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(AcademicsProgramConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(CategoryConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(CourseNoteConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(InstitutionConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(ScheduleConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(SubjectConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(SubjectsAcademicProgramConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(SubjectValueConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(UserAssignmentConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(UserCategoryConfiguration).Assembly);

        builder.ApplyConfigurationsFromAssembly(
            typeof(UserConfiguration).Assembly);
    }
}
