using Lab1.BussinessLogic.Helpers;
using Lab1.BussinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.BussinessLogic.Metrics
{
    public class FMeasure : IMeasurable
    {
        public double CalculateQuality(int[] actual, int[] expected)
        {
            CheckArraysLength(actual, expected);
            CheckArraysFilling(actual, expected);
            CheckArraysFromat(actual, expected);

            double TruePositive = 0;
            double TrueNegative = 0;
            double FalsePositive = 0;
            double FalseNegative = 0;

            for (int i = 0; i < actual.Length; i++)
            {
                TruePositive += actual[i] == 1 && actual[i] == expected[i] ? 1 : 0;
                TrueNegative += actual[i] == 0 && actual[i] == expected[i] ? 1 : 0;
                FalsePositive += actual[i] == 1 && actual[i] != expected[i] ? 1 : 0;
                FalseNegative += actual[i] == 0 && actual[i] != expected[i] ? 1 : 0;
            }

            double precision = TruePositive / (TruePositive + FalsePositive);
            double recall = TruePositive / (TruePositive + FalseNegative);
            double koef = 2;
            double result = (precision + recall) == 0 ? 0 : koef * precision * recall / (precision + recall);

            return result;
        }

        private void CheckArraysLength(int[] actual, int[] expected)
        {
            if (!Validation.IsArraysLengthEqual(actual, expected))
            {
                throw new Exception("Ошибка! Введённые массивы разной размерности.");
            }
        }

        private void CheckArraysFilling(int[] actual, int[] expected)
        {
            if (Validation.IsArrayEmpty(actual) || Validation.IsArrayEmpty(expected))
            {
                throw new Exception("Ошибка! Введённые массивы пусты.");
            }
        }

        private void CheckArraysFromat(int[] actual, int[] expected)
        {
            if (!Validation.DoesArrayContainOnly0and1Numbers(actual) ||
                !Validation.DoesArrayContainOnly0and1Numbers(expected))
            {
                throw new Exception("Ошибка! Введён массив неверного формата.");
            }
        }

    }
}
