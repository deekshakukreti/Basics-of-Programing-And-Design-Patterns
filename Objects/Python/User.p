
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
        

"""
Object of Class and call Login Method
"""
objUser = User('Jones', 'mj')
objUser.Login()
