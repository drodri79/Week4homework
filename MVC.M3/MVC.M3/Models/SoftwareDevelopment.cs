﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.M3.Models
{
    [Serializable]
    public class SoftwareDevelopment : IEnumerable
    {
        private GraphicDesign[] _softwaredev;
        public SoftwareDevelopment(GraphicDesign[] pArray)
        {
            _softwaredev = new GraphicDesign[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _softwaredev[i] = pArray[i];
            }
        }

        // Implementation for the GetEnumerator method.
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public SoftwareEnum GetEnumerator()
        {
            return new SoftwareEnum(_softwaredev);
        }
    }

    public class SoftwareEnum : IEnumerator
    {
        public GraphicDesign[] _softwaredev;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public SoftwareEnum(GraphicDesign[] list)
        {
            _softwaredev = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _softwaredev.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public GraphicDesign Current
        {
            get
            {
                try
                {
                    return _softwaredev[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

}

   
    
     
      
