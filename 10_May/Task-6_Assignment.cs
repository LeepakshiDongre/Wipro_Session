using System;

// Base class SocialMedia
class SocialMedia
{
    // Virtual method Post() that can be overridden in derived classes
    public virtual void Post()
    {
        Console.WriteLine("Posting on social media");
    }
}

// Derived class FacebookPost
class FacebookPost : SocialMedia
{
    // Override the Post() method to print a Facebook-specific message
    public override void Post()
    {
        Console.WriteLine("Posting on Facebook");
    }
}

// Derived class TwitterPost
class TwitterPost : SocialMedia
{
    // Override the Post() method to print a Twitter-specific message
    public override void Post()
    {
        Console.WriteLine("Tweeting on Twitter");
    }
}

// Derived class InstagramPost
class InstagramPost : SocialMedia
{
    // Override the Post() method to print an Instagram-specific message
    public override void Post()
    {
        Console.WriteLine("Posting on Instagram");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create objects for FacebookPost, TwitterPost, and InstagramPost
        SocialMedia fbPost = new FacebookPost();
        SocialMedia twitterPost = new TwitterPost();
        SocialMedia instaPost = new InstagramPost();

        // Call the Post() method for each object using polymorphism
        fbPost.Post();  // Output: Posting on Facebook
        twitterPost.Post();  // Output: Tweeting on Twitter
        instaPost.Post();  // Output: Posting on Instagram
    }
}
