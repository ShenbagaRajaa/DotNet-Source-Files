using System.ComponentModel.DataAnnotations;

namespace AssessmentWebApi;

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

public class UserLogin{
    public string? Username{get;set;}
    public string? Password{get;set;}
}

public class UserConstants
{
    public static List<UserModel> Users = new(){
        new UserModel() {Username="Shenba", Password="pass",Role="Manager"},
        new UserModel() {Username="Raj", Password="pass",Role="SalesMan"}
    };
}

public class UserModel
{
    public string? Username{get;set;}
    public string? Password{get;set;}
    public string? Role{get;set;}
}