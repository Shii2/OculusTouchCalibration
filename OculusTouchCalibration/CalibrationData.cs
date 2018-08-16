using System;

namespace OculusTouchCalibration
{
    [Serializable]
    public class CalibrationData
    {
        public TrackedObject TrackedObject;
    }

    [Serializable]
    public class TrackedObject
    {
        public int JsonVersion;
        public int JoyXRangeMax;
        public int JoyXRangeMin;
        public int JoyYRangeMax;
        public int JoyYRangeMin;
        public int JoyXDeadMax;
        public int JoyXDeadMin;
        public int JoyYDeadMax;
        public int JoyYDeadMin;
        public int TriggerMaxRange;
        public int TriggerMidRange;
        public int TriggerMinRange;
        public int MiddleMaxRange;
        public int MiddleMidRange;
        public int MiddleMinRange;
        public bool MiddleFlipped;
        public string IrLedConfig;
        public double[] ImuPosition;
        public double[] GyroCalibration;
        public double[] AccCalibration;
        public int[] CapSenseMin;
        public int[] CapSenseTouch;
        public ModelPoints ModelPoints;
        public Lensing Lensing;
    }

    [Serializable]
    public class ModelPoints
    {
        public decimal[] Point0;
        public decimal[] Point1;
        public decimal[] Point2;
        public decimal[] Point3;
        public decimal[] Point4;
        public decimal[] Point5;
        public decimal[] Point6;
        public decimal[] Point7;
        public decimal[] Point8;
        public decimal[] Point9;
        public decimal[] Point10;
        public decimal[] Point11;
        public decimal[] Point12;
        public decimal[] Point13;
        public decimal[] Point14;
        public decimal[] Point15;
        public decimal[] Point16;
        public decimal[] Point17;
        public decimal[] Point18;
        public decimal[] Point19;
        public decimal[] Point20;
        public decimal[] Point21;
        public decimal[] Point22;
        public decimal[] Point23;
    }

    [Serializable]
    public class Lensing
    {
        public double[] Model0;
        public double[] Model1;
        public double[] Model2;
    }
}