using Microsoft.AspNetCore.Identity;

namespace JWTwebapi;

public class UserConstants
{
    public static List<UserModel> Users = new(){
        new UserModel() {Username="Shenba", Password="pass",Role="CTO"}
    };
}


