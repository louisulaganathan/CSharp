Fields:
========
A field is a variable of any type that is declared directly in a class or struct. Fields are members of their containing type.
A class or struct may have instance fields, static fields, or both. Instance fields are specific to an instance of a type.
Generally, you should use fields only for variables that have private or protected accessibility.
Data that your class exposes to client code should be provided through methods, properties, and indexers.
By using these constructs for indirect access to internal fields, you can guard against invalid input values.
A private field that stores the data exposed by a public property is called a backing store or backing field.
public class CalendarEntry
{
    // private field
    private DateTime date;

    // public field (Generally not recommended.)
    public string day;

    // Public property exposes date field safely.
    public DateTime Date
    {
        get
        {
            return date;
        }
        set
        {
            // Set some reasonable boundaries for likely birth dates.
            if (value.Year > 1900 && value.Year <= DateTime.Today.Year)
            {
                date = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }

    // Public method also exposes date field safely.
    // Example call: birthday.SetDate("1975, 6, 30");
    public void SetDate(string dateString)
    {
        DateTime dt = Convert.ToDateTime(dateString);

        // Set some reasonable boundaries for likely birth dates.
        if (dt.Year > 1900 && dt.Year <= DateTime.Today.Year)
        {
            date = dt;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}