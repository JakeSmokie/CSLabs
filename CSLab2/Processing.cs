﻿using ClassLib;
using CSLabs.Operations;
using System.Collections.Generic;

namespace CSLabs
{
    class Processing : GenericProcessing
    {
        private List<string> operationsBuffer;

        public Processing() : base()
        {
            operations.Add(new Load());
            operations.Add(new Save());

            operationsBuffer = new List<string>();
        }

        public override void Loop()
        {
            while (currentOperation.Run(mathBuffer, operationsBuffer))
            {
                UpdateOperationsBuffer();
                currentOperation = parser.Read(operations);
            }
        }

        private void UpdateOperationsBuffer()
        {
            if (currentOperation.OperatorChar.IsOneOf('l', 's', 'q'))
            {
                return;
            }

            string expression;

            switch (currentOperation.OperatorChar)
            {
                case '\0':
                    expression = mathBuffer.values[0].ToWolfString();
                    break;  
                case '#':
                    expression = $"Out[{ mathBuffer.lastTempValue }]";
                    break;
                default:
                    expression = $"Out[-1] { currentOperation.OperatorChar } { mathBuffer.lastTempValue.ToWolfString() } ";
                    break;
            }

            operationsBuffer.Add(expression);
        }
    }
}
