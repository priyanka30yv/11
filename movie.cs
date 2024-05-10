using System;
namespace Weekend
{
class Movie{
private string movieName;

private string duration;
private string releaseDate;
public Movie(){}
public Movie(string a,string b,string c)
{
movieName=a;
duration=b;
releaseDate=c;


}
public void displayData()
{
Console.WriteLine($"the movie is {movieName} and the duration is {duration} and this movie release in date {releaseDate}");
}


}
class Theatre
{
public static void Main(string[] args)
{
Movie obj=new Movie("gadar","2.30 Hours","12/11/2010");
Movie obj1=new Movie();
obj.displayData();
obj1.displayData();

}
}

}