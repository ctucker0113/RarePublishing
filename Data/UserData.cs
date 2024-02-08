using RarePublishing.Models;

namespace RarePublishing.Data
{
    public class UserData
    {

        List<Users> users = new List<Users>
        {
            new Users() {Id=0, FirstName= "Tom", LastName="Jones", Email="tomjones@raptor.com", Bio="Singer", UserName="TJonesSings1", Password = "S1ng3r1", ProfileImageUrl="", CreatedOn="2015, 11, 17", Active=true},
            new Users() {Id=1, FirstName="James", LastName="Madison",Email="jmadison@raptor.com", Bio="Historian", UserName="JMadisonHistory", Password="JMHistory1", ProfileImageUrl="",CreatedOn="2023, 8, 23", Active=false},
            new Users() {Id=2, FirstName="Ben", LastName="Franklin", Email="bfranklin@raptor.com", Bio="Lightening Rod", UserName="LighteningRod",Password="LR1234Ben", ProfileImageUrl="",CreatedOn="2024, 7, 14", Active=true},
            new Users() {Id=3, FirstName="Dolly", LastName="Madison", Email="dmadison@raptor.com", Bio="Cakes and Flags", UserName="HostessFlags", Password="Ho$tess1814", ProfileImageUrl="https://i5.walmartimages.com/asr/08fffc3e-5ab3-49ac-b2f4-437d745518eb.4f852827a30c3959302e0b2ddb8322d4.jpeg?odnHeight=640&odnWidth=640&odnBg=FFFFFF", CreatedOn="2023, 9, 12", Active=true},
            new Users() {Id=4, FirstName="George", LastName="Carlin", Email="funnymanGC@raptor.com", Bio="Satirical Comedy", UserName="FunnyManGC", Password="AmBlows", ProfileImageUrl="https://static01.nyt.com/images/2008/06/23/obituaries/23carlin-500.jpg",CreatedOn="2008, 6, 21", Active=true}
        };

    };

}




