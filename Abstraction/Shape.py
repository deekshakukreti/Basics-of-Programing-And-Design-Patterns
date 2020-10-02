from abc import ABC, abstractmethod
 
class Shape(ABC):
    
    @abstractmethod
    def GetNumberofCorners(self):
        pass
        
class Pentagon(Shape):
    def GetNumberofCorners(self):
        print("Pentagon has five corners.")
        
x = Pentagon()
x.GetNumberofCorners()