using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

namespace AirlineMS.Models;

public class Ticket
{
     [StringLength(7,MinimumLength = 7,ErrorMessage = "FinCode has to consist of maximum 7 elements.")]
     //[RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{7}$",ErrorMessage = "FinCode has to consist of maximum 7 elements.")]
    public required string FinCode { get; set; }
    
    public int Phone { get; set; }
    public required string Name { get; set; }
    public required string Surname { get; set; }
    //[EmailAddress]
    [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$",ErrorMessage = "Please,enter your email account correctly.")]
    public required string Email { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime DepartureDate { get; set; }
   
    [DataType(DataType.DateTime)]
    public DateTime ReturnDate { get; set; }
    public required string DepartingCity { get; set; }
    public required string DestinationCity { get; set; }
    public required string Airline { get; set; }
}