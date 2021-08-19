using System;
using System.Text;

public class Student
{
	private string FullName { get; set; }

	private string Email { get; set; }

	public Student(string email)
    {
		Email = email;
		FullName = ParseEmailToFullName(email);
    }

	public Student(string name, string surname)
    {
        FullName = name + " " + surname;
        Email = GetEmailFromFullName(name, surname);
    }

	private string ParseEmailToFullName(string email)
    {
       StringBuilder fullname = new StringBuilder();
       for (int i = 0; i < email.Length; i++)
       {
            if (email[i].Equals('@')) break;
            if (email[i].Equals('.'))
            {
                fullname.Append(' ');
                continue;
            }
            fullname.Append(email[i]);           
       }
       return fullname.ToString();
      
    }

	private string GetEmailFromFullName(string name, string surname)
    {
        return name + '.' + surname + "@epam.com";
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
