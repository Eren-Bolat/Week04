namespace StudentRegister;

public struct CourseCode
{
    public string Code { get; set; }
    public int Credits { get; set; }

    public CourseCode(string code, int credits)
    {
        Code = code;
        Credits = credits;
    }

    public override string ToString()
    {
        return $"{Code} ({Credits} credits)";
    }
}
