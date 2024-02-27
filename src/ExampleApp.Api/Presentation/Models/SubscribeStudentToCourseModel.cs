using Microsoft.AspNetCore.Mvc;

namespace ExampleApp.Api.Controllers.Models;

public record StudentModel(string FullName, int Badge);

public record SubscribeStudentToCourseModel([FromQuery] Guid CourseId, [FromBody] StudentModel Student);
