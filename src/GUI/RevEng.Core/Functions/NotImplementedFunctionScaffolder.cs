﻿using System.Collections.Generic;
using System.Text;
using System;
using Microsoft.EntityFrameworkCore.Scaffolding;
using RevEng.Core.Abstractions.Metadata;
using RevEng.Core.Abstractions;

namespace RevEng.Core.Functions
{
    public class NotImplementedFunctionScaffolder : IFunctionScaffolder
    {
        public SavedModelFiles Save(ScaffoldedModel scaffoldedModel, string outputDir, string nameSpaceValue)
        {
            throw new NotSupportedException();
        }

        public ScaffoldedModel ScaffoldModel(RoutineModel model, ModuleScaffolderOptions scaffolderOptions, ref List<string> errors)
        {
            throw new NotSupportedException();
        }
    }
}
