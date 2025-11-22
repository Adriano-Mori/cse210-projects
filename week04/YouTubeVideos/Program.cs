using System;
using System.Collections.Generic;
//Decided to remove the "Channel" class and some methods/variables from the other classes
//since I later realized that those were unnecessary.
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        //vid 1
        Video vid1 = new Video("Hi this is my first video!", "Alex", 400);
        vid1.AddComment(new Comment("RickGaming67", "Yo"));
        vid1.AddComment(new Comment("AngeloZd", "chat is this real"));
        vid1.AddComment(new Comment("Luis", "Great video!"));
        videos.Add(vid1);
        //vid 2
        Video vid2 = new Video("MINECRAFT'S MOST INTERESTING SEEDS", "L_Chungus", 1610);
        vid2.AddComment(new Comment("DrainStrain_05", "2:05 was insane fr"));
        vid2.AddComment(new Comment("Mark", "Amazing vid as always chungus!"));
        vid2.AddComment(new Comment(".", "already saw it, delete pls"));
        videos.Add(vid2);
        //vid 3
        Video vid3 = new Video("Best things you can find under a rock", "bug.", 840);
        vid3.AddComment(new Comment("ant", "as a certified ant I completely agree"));
        vid3.AddComment(new Comment("ant2", "Cool vid. btw you got any crumbs? I got a colony to feed."));
        vid3.AddComment(new Comment("IsopodGaming15", "I can't agree more"));
        vid3.AddComment(new Comment("regular_isopod", "MY HOUSE APPEARED AHHH"));
        vid3.AddComment(new Comment("Jerry", "can we stop pretending we are bugs?"));
        videos.Add(vid3);
        //display 
        foreach (Video video in videos)
        {
            video.DisplayDetails();
        }
    }
}