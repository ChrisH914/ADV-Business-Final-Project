public class Borrower
{
    public int BorrowerID { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }

    public ICollection<BorrowRecord>? BorrowRecords { get; set; }
}

public class BorrowRecord
{
    public int BorrowRecordID { get; set; }
    public int BorrowerID { get; set; }
    public int BookID { get; set; }
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }

    public Borrower? Borrower { get; set; }
    public Book? Book { get; set; }
}
