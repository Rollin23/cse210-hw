using System;

class Program
{
    private static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        Video vid1 = new Video();
        Video vid2 = new Video();
        Video vid3 = new Video();
        Video vid4 = new Video(); 

        vid1.SetVideo("Crazy Road Rage", "Time Allen", 152);
        Comment comment1 = new Comment();
        Comment comment2 = new Comment();
        Comment comment3 = new Comment();
        Comment comment4 = new Comment();
        Comment comment5 = new Comment();

        comment1.SetComment("Jeff Bone", "Wow, this is why there should be stricter requirements to get a license");
        comment2.SetComment("Cathryn Rollins", "I can't believe they walked away");
        comment3.SetComment("Stephen Rollins", "You can't park there bro");
        comment4.SetComment("Suzanne Mulvany", "I Hope they're okay");
        comment5.SetComment("Paul Blart", "Should've used a segway");
         
        vid1.AddComment(comment1);
        vid1.AddComment(comment2);
        vid1.AddComment(comment3);
        vid1.AddComment(comment4);
        vid1.AddComment(comment5);


        vid2.SetVideo("Real or Cake?", "Leroy Jenkins", 36);
        Comment comment14 = new Comment();
        Comment comment15 = new Comment();
        Comment comment16 = new Comment();

        comment14.SetComment("Don Runnels", "I knew it was cake!");
        comment15.SetComment("Chris Cringle", "it looks so good!");

        vid2.AddComment(comment14);
        vid2.AddComment(comment15);

        vid3.SetVideo("Life Hacks", "John Dillon", 58);
        Comment comment11 = new Comment();
        Comment comment12 = new Comment();
        Comment comment13 = new Comment();

        comment11.SetComment("Tom Riddle", "They make a tool for that");
        comment12.SetComment("Chuck Norris", "Fixing things with ramen is not a hack" );
        comment13.SetComment("Bernie Ming", "Wow this was so cleaver");

        vid3.AddComment(comment11);
        vid3.AddComment(comment12);
        vid3.AddComment(comment13);

        vid4.SetVideo("Golf Trick Shots", "Dude Perfect", 456);
        
        Comment comment6 = new Comment();
        Comment comment7 = new Comment();
        Comment comment8 = new Comment();
        Comment comment9 = new Comment();
        Comment comment10 = new Comment();
        
        comment6.SetComment("Mac Miller", "Ball golf is whack");
        comment7.SetComment("John Rollins", "Too much time on their hands.");
        comment8.SetComment("Tim Tobbler", "I wonder how many tries that took them?");
        comment9.SetComment("Bo Vincelet", "These guys have my dream job");
        comment10.SetComment("Gerret Gholson", "This is totally fake!");
        
        vid4.AddComment(comment6);
        vid4.AddComment(comment7);
        vid4.AddComment(comment8);
        vid4.AddComment(comment9);
        vid4.AddComment(comment10);

        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);
        videos.Add(vid4);

        foreach (Video vid in videos)
        {
            vid.Display();
        }
    }
        
}