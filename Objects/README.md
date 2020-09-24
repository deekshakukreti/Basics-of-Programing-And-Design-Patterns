# Objects and Classes

Objects binds data associated with the entities for which the program is designed to function. An object has attribute, and in OOP the attribute of an object are referred as 
properties. Objects reveal behaviours through methods. The properties and methods of the object used in OOP are defined through classes.

## Defining Class, Properties and Methods
```csharp

class User
{
  private int _userID;
  private string _userName;
  private string _password;
  private string _Age;
  private string _name;
  
  public string Name
  {
    get { return _name; }
    set { _name = value; }
  }
  
  public int UserID
  {
    get { return _userID; }
  }
  
  public string Password
  {
    get { return _password; }
    set
    {
        if (value.Length >= 10)
        {
            _password = value;
        }
        else
        {
            throw new Exception("Password must be at least 10 characters");
        }
   }
}
}

```

```python

class User:
  def __init__(self, _userID, _userName, _password, _Age, _name):
      self._userID = _userID
      self._userName = _userName
      self._password = _password
      self._Age = _Age
      self._name = _name
      
```



