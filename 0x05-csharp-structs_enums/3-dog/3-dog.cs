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

    public override string ToString()
    {
        return String.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
    }
}
