# csharp-weightedprobability
 
A easy-to-use Weighted Probability class implemented in C#. Mainly developed for using with Unity games, but ready for using in any other ways and projects (it's non Unity-dependent).

## How to use:
- ```WeightedProbability<T>.AddItem(T object, double weight)``` - Add an custom object with specified weight. Don't miss setting the type of object at ```<T>``` in class.
- ```WeightedProbability<T>.AddMultipleItems(T[] objects, double commonWeight)``` - Add multiple objects (passed as array) with the same specified common weight. Don't miss setting the type of object at ```<T>``` in class.
- ```WeightedProbability<T>.Sort()``` - Randomize and returns an object of type ```T```. Returns ```null``` if no objects are pre-added to class. Don't miss setting the type of object at ```<T>``` in class.
- ```WeightedProbability<T>.Reset()``` - Removes all objects and resets previously set weights for re-using the class. Don't miss setting the type of object at ```<T>``` in class.

## Notes:
- The class and his methods are static, so you don't need to declare objects of type ```WeightedProbability<T>``` to use.
- It's very important (and obvious) adding objects with same type (and expecting the return from ```Sort``` will be this object type).
- You can add multiple types of objects? Yes, but I'm not responsible in what will happen if you do this. :)