﻿using PublicApiGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaFac.CG5.Expressions.Tests
{
    public class RegressionChecks
    {
        [Fact]
        public async Task MetaFac_PublicApi_Parsing()
        {
            // act
            var options = new ApiGeneratorOptions()
            {
                IncludeAssemblyAttributes = false
            };
            string currentApi = ApiGenerator.GeneratePublicApi(typeof(MetaFac.CG5.Parsing.Combinators).Assembly, options);

            // assert
            await Verifier.Verify(currentApi);
        }

        [Fact]
        public async Task MetaFac_PublicApi_Expressions()
        {
            // act
            var options = new ApiGeneratorOptions()
            {
                IncludeAssemblyAttributes = false
            };
            string currentApi = ApiGenerator.GeneratePublicApi(typeof(MetaFac.CG5.Expressions.CG5Parser).Assembly, options);

            // assert
            await Verifier.Verify(currentApi);
        }

    }
}