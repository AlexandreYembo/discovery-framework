using System;
using System.Collections.Generic;

namespace Discovery.Implementation
{
    public class SetupModel{
        public List<ModelTest> Setup(){
            Guid guid = Guid.NewGuid();
            List<ModelTest> list = new List<ModelTest>();
            list.Add(new ModelTest{
                Id = guid,
                Name = "Alexandre 1",
                Order = 1,
                Prop1 = new ModelTest1{
                    Id = Guid.NewGuid(),
                    Type = "Type 1"
                }
            });

            list.Add(new ModelTest{
                Id = Guid.NewGuid(),
                Name = "Alexandre 2",
                Order = 1,
                Prop1 = new ModelTest1{
                    Id = Guid.NewGuid(),
                    Type = "Type 2"
                }
            });

            list.Add(new ModelTest{
                Id = guid,
                Name = "Alexandre 1",
                Order = 1,
                Prop1 = new ModelTest1{
                    Id = Guid.NewGuid(),
                    Type = "Type 2"
                }
            });

             list.Add(new ModelTest{
                Id = guid,
                Name = "Alexandre 1",
                Order = 1,
                Prop1 = new ModelTest1{
                    Id = Guid.NewGuid(),
                    Type = "Type 2"
                }
            });

             list.Add(new ModelTest{
                Id = Guid.NewGuid(),
                Name = "Alexandre 1",
                Order = 1,
                Prop1 = new ModelTest1{
                    Id = Guid.NewGuid(),
                    Type = "Type 2"
                }
            });

            return list;
        }
    }
    public class ModelTest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Order { get; set; }

        public ModelTest1 Prop1 { get; set; }
    }

    public class ModelTest1{
         public Guid Id { get; set; }
        public string Type { get; set; }
    }
}