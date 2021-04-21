# opendigitaltwins-dtdl-semantictypes-dotnet

Open Digital Twins DTDL specifies a set of semantic types that convey meaning beyond simple value, such as the Unit of Measure that is intended. 

This library provides .NET types that match these specifications, so that you can rehydrate a Digital Twin model and preserve semantic meaning.

The underlying numeric type of this Lib is a `System.Double`. 

## Installation

`dotnet add package Elastacloud.OpenDigtialTwins.Dtdl.SemanticTypes`

## Usage 

**Create an Acceleration Semantic Type from a double**
```csharp
Acceleration au = (Acceleration)167.168d;
```

**Create an Acceleration Semantic Type with ctor and specify the Unit Type Unit of Measure**

```csharp
Acceleration a = new Acceleration(167.168d, UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.metrePerSecondSquared);
            
var actual = a.ToString();

// output : "167.168m/s2"
```

**Access the Underlying Value for comparison**
```csharp
Acceleration au = (Acceleration)167.168d;
Acceleration au2 = (Acceleration)167.168d;

Assert.Equal(au.Value, au2.Value);
```

**Specify the global Semantic Unit Type Unit of Measure**

```csharp
DefaultUnitOfMeasures.Acceleration = UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.gForce;
Acceleration au = (Acceleration)167.168d;
            
var actual = au.ToString();

Assert.Equal("167.168G", actual);
```

**Special Equality on Semantic Types**


```csharp
Acceleration a1 = new Acceleration(167.168d, UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.metrePerSecondSquared);

Acceleration a1 = new Acceleration(167.168d, UnitTypes.AccelerationUnit.AccelerationUnitOfMeasure.gForce);
            
Assert.NotEqual(a1, a2);
```

## Completeness

There is an implementation of all UnitTypes, but only Acceleration is only implemented for Semantic Types. 