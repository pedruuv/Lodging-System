namespace Lodging_System.Models;

public class Reservation
{
    public Reservation(int reservedDays)
    {
        if (reservedDays <= 0)
            throw new ArgumentException("Reserved days must be greater than 0");
        _reservedDays = reservedDays;
    }

    private List<Person> _guests;
    private Suite _suite;
    private int _reservedDays;

    public void SignUpGuests(List<Person> guests)
    {
        if (guests.Count > _suite.Capacity)
        {
            throw new InvalidOperationException("Too many guests");
        }
        _guests = guests;
    }

    public void SignUpSuite(Suite suite)
    {
        _suite = suite ?? throw new ArgumentNullException(nameof(suite), "Suite cannot be null");
    }

    public int GetGuestCount()
    {
        return _guests.Count;
    }

    public decimal CalculateDailyRate()
    {
        if (_reservedDays >= 10)
            return _suite.DailyRate * _reservedDays * 0.90M;
        
        return _suite.DailyRate * _reservedDays;
    }
}