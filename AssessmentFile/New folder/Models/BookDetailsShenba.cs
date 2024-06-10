using System.ComponentModel.DataAnnotations;

namespace AssessmentFile;

public class BookDetailsShenba
{
    [Key]
    public int BookId {get;set;}
    public string BookName {get;set;}
    public string Author {get; set;}
    public int Generation {get; set;}
    public double Price {get;set;}
    public int StockInHand {get;set;}
}
