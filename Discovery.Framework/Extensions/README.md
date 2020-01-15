# LINQ

## Distinct Extension

### 1- Distinct By

#### How does it work?
```Distinct Extension``` is a class to help the implementation by using Distinct, implement IEqualityComparer but using a generic way that you don't need to create a customize class for each model type. So you can implement by using extension.

#### Parameters
DistinctBy expects only your expression. Basically the method passing a ```Func<T, TKey> property``` that means your expression defined by a property you want to use to distinct the as an element of your list.


#### How to implement
In your project, if you want to distinct a list of duplicated element you can pass as parameter the propert you want to use comparison.

``` c#
     var myList = [..] // this is my original list
     var myDistictList = myList.DistinctBy(d => d.PropertyName).ToList(); // In a simply way just use the method DistinctBy(expression)

```