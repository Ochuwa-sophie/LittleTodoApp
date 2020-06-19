using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
public class TodoItem
{
public Guid Id { get; set; }
public bool IsDone { get; set; }
[Required]
public string Title { get; set; }//strings are always nullable/optional
public DateTimeOffset? DueAt { get; set; }//the question mark here means it's optional
}
}
