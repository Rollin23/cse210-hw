using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video vid1 = new Video("Crazy Road Rage", "Time Allen", 152);
        vid1.AddComment(new Comment("Jeff Bone", "Wow, this is why there should be stricter requirements to get a license"));
        vid1.AddComment(new Comment("Cathryn Rollins", "I can't believe they walked away"));
        vid1.AddComment(new Comment("Stephen Rollins", "You can't park there bro"));
        vid1.AddComment(new Comment("Suzanne Mulvany", "I Hope they're okay"));
        vid1.AddComment(new Comment("Paul Blart", "Should've used a segway"));

        Video vid2 = new Video("Real or Cake?", "Leroy Jenkins", 36);
        vid2.AddComment(new Comment("Don Runnels", "I knew it was cake!"));
        vid2.AddComment(new Comment("Chris Cringle", "it looks so good!"));

        Video vid3 = new Video("Life Hacks", "John Dillon", 58);
        vid3.AddComment(new Comment("Tom Riddle", "They make a tool for that"));
        vid3.AddComment(new Comment("Chuck Norris", "Fixing things with ramen is not a hack"));
        vid3.AddComment(new Comment("Bernie Ming", "Wow this was so cleaver"));

        Video vid4 = new Video("Golf Trick Shots", "Dude Perfect", 456);
        vid4.AddComment(new Comment("Mac Miller", "Ball golf is whack"));
        vid4.AddComment(new Comment("John Rollins", "Too much time on their hands."));
        vid4.AddComment(new Comment("Tim Tobbler", "I wonder how many tries that took them?"));
        vid4.AddComment(new Comment("Bo Vincelet", "These guys have my dream job"));
        vid4.AddComment(new Comment("Gerret Gholson", "This is totally fake!"));

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