 
![GitHub release](https://img.shields.io/github/release/singhrahulnet/lms.api.svg?style=for-the-badge) ![Maintenance](https://img.shields.io/maintenance/yes/2018.svg?style=for-the-badge)

![GitHub Release Date](https://img.shields.io/github/release-date/singhrahulnet/lms.api.svg?style=plastic) |[![.Net Framework](https://img.shields.io/badge/DotNet-Framework_2.1-blue.svg?style=plastic)](https://www.microsoft.com/net/download/dotnet-core/2.1) | ![GitHub language count](https://img.shields.io/github/languages/count/singhrahulnet/lms.api.svg?style=plastic)| ![GitHub top language](https://img.shields.io/github/languages/top/singhrahulnet/lms.api.svg) 
| ---        | ---      | ---       | --- |
## Shipment Service 
A console application to showcase *Chain Of Responsibility* design pattern with *dependency injection*.

## Problem Statement
Develop a service for a shipping company to calculate cost and type of package required to ship an item. The input supplied will be dimensions and weight of the item. The upper limit of weight is 25kg per package.

| Package Type| Length | Breadth | Height | Cost
| --- | --- | --- | --- | --- |
| Small| 200mm | 300mm | 150mm | $5 
| Medium| 300mm | 400mm | 200mm | $10
| Large| 400mm | 600mm | 250mm | $15 



## Other Details

#### Environment Setup

> Download/install [![.Net Framework](https://img.shields.io/badge/DotNet-Framework_2.1-blue.svg?style=plastic)](https://www.microsoft.com/net/download/dotnet-core/2.1) to run project   
 

>   Kindly clone /download the repository.

>   Open the solution file 'ShipmentSolution.sln' from VisualStudio 2017

>   Build and Run the project


#### Chain of Responsibility
> Open Domain/PackageHandler.cs

> Look for following variable. The variable holds reference of the next handler (of responsibility).

```csharp
        protected PackageHandler nextPackage;
```
> Notice that *HandlePackage* method is called **recursively**.
```csharp
   else if (OverSized(dimension))
            {
                //Cannot handle it. Passing it to a bigger guy
                if (nextPackage != null) nextPackage.HandlePackage(dimension, ref result);
            }
```

## Support or Contact

Having any trouble? Please read out this [documentation](https://github.com/singhrahulnet/ChainOfResponsibility/blob/master/README.md) or [contact](mailto:singh.rahul.net@gmail.com) and to sort it out.

 [![HitCount](http://hits.dwyl.io/singhrahulnet/ChainOfResponsibility/projects/1.svg)](http://hits.dwyl.io/singhrahulnet/ChainOfResponsibility/projects/1) | ![GitHub contributors](https://img.shields.io/github/contributors/singhrahulnet/ChainOfResponsibility.svg?style=plastic)|
 | --- | --- |
 
Keep Coding :-) 
