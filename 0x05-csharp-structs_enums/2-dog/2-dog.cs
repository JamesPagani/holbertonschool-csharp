using System;

enum Rating
{
    Good,
    Great,
    Excellent
}


struct Dog
{
    public Dog(string dogName, float dogAge, string dogOwner, Rating dogRating)
    {
        name = dogName;
        age = dogAge;
        owner = dogOwner;
        rating = dogRating;
    }
    public string name;
    public float age;
    public string owner;
    public Rating rating;
}
