# Objects and Classes

Objects binds data associated with the entities for which the program is designed to function. An object has attribute, and in OOP the attribute of an object are referred as 
properties. Objects reveal behaviours through methods. The properties and methods of the object used in OOP are defined through classes.

## Defining Class, Properties and Methods
## C# code
```csharp

 class User
    {
        private int _userID;
        private string _userName;
        private string _password;
        private int _floor;

        /*
         * Properties Definition
         */
        public int UserID
        {
            get { return _userID; }
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int Floor
        {
            get { return _floor; }
        }
        
        
        /*
         * Method : Login
         * Input Parameters : UserName and Password
         * Output Parameter : Boolean value : Returns True if the Username and Passoword Matched 
         * else it returns False
         */
        public Boolean Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
            if (userName == "Smith" & password == "js")
            {
                _userID = 1;
                _floor = 2;
                Console.WriteLine("Its done");
                return true;
            }
            else if (userName == "Jones" & password == "mj")
            {
                _userID = 2;
                _floor = 4;
                return true;
            }
            else
            {
                return false;
            }
        }

```
## Some Useful Information
For newcomers it is really important to understand the significance of properties with get and set commands. Why don't we just define public instance variables in the class to read and write data? The answer is very simple! It's because of Encapsulation which helps to keep the data hidden from client direct access to the code. It is very important to note that when working with data client code must use clearly defined properties. This helps to ensure integrity and prevents unauthorised access to the data. Also, it creates read-only and write-only properties.

## Python code
```python

"""
Created on Fri Sep 25 14:16:41 2020
@author: Deeksha Kukreti
"""
class User:    
    def __init__(self, _userName, _password):        
        self._userName = _userName
        self._password = _password
        
    def Login(self):
        UserName = self._userName
        Password = self._password
        
        if (UserName == 'Smith' and Password == 'js'):
            _userID = 1
            _floor = 2
            return True
        elif (UserName == "Jones" and Password == "mj"):
            _userID = 2
            _floor = 4
            return True
        else:
            return False
      
```

# Summary
The section educates in creating classes and objects. In the next section, I will implement deeper concepts of OOP. 

