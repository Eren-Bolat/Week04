namespace StudentRegister;

public abstract class Person
{
    public string name;
    protected int id;

    protected Person(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public abstract void Describe();
}
