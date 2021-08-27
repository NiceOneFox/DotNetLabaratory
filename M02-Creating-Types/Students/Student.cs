using System;
using System.Text;

public class Student
{
    public string FullName { get; private set; }

    public string Email { get; private set; }

    public Student(string email)
    {
        Email = email;
        FullName = ParseEmailToFullName();
    }

    public Student(string name, string surname)
    {
        FullName = name + " " + surname;
        Email = GetEmailFromFullName();
    }

    private string ParseEmailToFullName()
    {
        StringBuilder fullname = new StringBuilder();
        for (int i = 0; i < Email.Length; i++)
        {
            if (Email[i].Equals('@')) break;
            if (Email[i].Equals('.'))
            {
                fullname.Append(' ');
                continue;
            }
            fullname.Append(Email[i]);
        }
        return fullname.ToString();

    }

    private string GetEmailFromFullName()
    {
        string temp = FullName;
        temp = temp.Replace(' ', '.');
        return temp + "@epam.com";
    }

    public override bool Equals(object obj)
    {
        //Check for null and compare run-time types.
        if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        {
            return false;
        }
        Student s = (Student)obj;
        return (s.Email == Email && s.FullName == FullName);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(FullName, Email);
    }
}
