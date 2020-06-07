/*
WeightedProbability.cs
Version: 1.0.0
Author: RBFraphael
Author Website: https://www.rbfraphael.com.br
Repository: https://github.com/rbfraphael/csharp-weightedprobability
License: GPL v3 or newer
*/

using System;
using System.Collections.Generic;

public class WeightedProbability<T>
{
    private class WeightedProbabilityItem {
        public T obj;
        public double weight;

        public WeightedProbabilityItem(T obj, double weight)
        {
            this.obj = obj;
            this.weight = weight;
        }
    }

    private static List<WeightedProbabilityItem> items = new List<WeightedProbabilityItem>();
    private static double totalWeight = 0;
    private static Random random = new Random();

    public static void AddItem(T obj, double weight)
    {
        totalWeight += weight;
        items.Add(new WeightedProbabilityItem(obj, totalWeight));
    }

    public static void AddMultipleItems(T[] objs, double commonWeight)
    {
        foreach(T obj in objs){
            totalWeight += commonWeight;
            items.Add(new WeightedProbabilityItem(obj, totalWeight));
        }
    }

    public static T Sort()
    {
        double sortedWeight = random.NextDouble() * totalWeight;

        foreach(WeightedProbabilityItem item in items){
            if(item.weight >= sortedWeight){
                return item.obj;
            }
        }

        return default(T);
    }

    public static void Reset()
    {
        totalWeight = 0;
        items.Clear();
    }
}