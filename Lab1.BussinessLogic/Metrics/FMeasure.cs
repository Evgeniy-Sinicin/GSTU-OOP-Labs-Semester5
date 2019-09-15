using Lab1.BussinessLogic.Helpers;
using Lab1.BussinessLogic.Interfaces;
using System;

namespace Lab1.BussinessLogic.Metrics
{
    public class FMeasure : IMeasurable
    {
        /// <summary>
        /// Вычисляет качество работы алгоритма
        /// </summary>
        /// <param name="actual">Массив с фактическими значениями</param>
        /// <param name="expected">Массив с ожидаемыми значениями</param>
        /// <returns></returns>
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
                TruePositive += expected[i] == 1 && actual[i] == expected[i] ? 1 : 0;
                TrueNegative += expected[i] == 0 && actual[i] == expected[i] ? 1 : 0;
                FalsePositive += expected[i] == 1 && actual[i] != expected[i] ? 1 : 0;
                FalseNegative += expected[i] == 0 && actual[i] != expected[i] ? 1 : 0;
            }

            double accuracy = (TrueNegative + TruePositive) / (TrueNegative + TruePositive + FalsePositive + FalseNegative);
            if(accuracy == 1)
            {
                return 1;
            }
            else if(accuracy == 0)
            {
                return 0;
            }
            else
            {
                double precision = TruePositive / (TruePositive + FalsePositive);
                double recall = TruePositive / (TruePositive + FalseNegative);
                double koef = 2;
                return koef * precision * recall / (precision + recall);
            }
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
