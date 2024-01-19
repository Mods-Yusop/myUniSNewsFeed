
using myUniS.Models;
namespace myUniS.Views;

public partial class HomePage : ContentPage
{

    public HomePage()
	{
        InitializeComponent();
        CollectionView.ItemsSource = GetUsers();
    }

    private List<UserPostDetails> GetUsers()
    {
        return new List<UserPostDetails>
        {
            new UserPostDetails{ UserImage="diverte.png",UserName = "Joseph Diverte", TimeCreated = "13 mins ago", Handle = "@jd",
            Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor \r\n\r\naliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut",
            Likes = 13, Comments=2,Dislikes=4},

            new UserPostDetails{ UserImage="jonash.png",UserName = "Jonash Largo", TimeCreated = "2 days ago", Handle = "@jl",
            Post = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor ",
            Likes = 5, Comments=3,Dislikes=1},

            new UserPostDetails{ UserImage="ceit.png",UserName = "CEIT", TimeCreated = "1 hour ago", Handle = "@collegeofengineering",
            Post = "vLorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor",
            Likes = 112, Comments=4,Dislikes=2}
        };
    }

}