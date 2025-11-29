using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchNet
{
    public class FunctionDeclaration : Function
    {
        public FunctionDeclaration()
        {
            Params = new List<Parameter>();
            Body = new BlockStatement();
        }
        public override List<Parameter> Params { get; set; }
        public override string Name { get; set; }
        public override BlockStatement Body { get; set; }

        public Completion Execute(ExecutionEnvironment enviroment)
        {
            throw new NotImplementedException();
        }

        protected override Completion ExecuteImpl(ExecutionEnvironment enviroment)
        {
            throw new NotImplementedException();
        }

        public override string ReturnType
        {
            get { return "number|boolean|string"; }
        }

        public override Descriptor Descriptor
        {
            get
            {
                Descriptor desc = new Descriptor();
                desc.Add(new TextItemDescriptor(this, Name+ "("));
                int i = 0;
                foreach (Parameter p in Params)
                {
                    if (i != 0)
                        desc.Add(new TextItemDescriptor(this, ","));
                    desc.Add(new ParameterDescriptor(this, i, p.Name, p.Type, p.Direction));
                    i++;
                }
                desc.Add(new TextItemDescriptor(this, ")"));
                return desc;
            }
        }

        public override string Type
        {
            get { return "FunctionDeclaration"; }
        }


        public override BlockDescriptor BlockDescriptor
        {
            get
            {
                BlockDescriptor desc = new BlockDescriptor();
                desc.Add(new BlockStatementDescriptor(this, "Body"));
                return desc;
            }
        }
        public bool IsClosing
        {
            get { return false; }
        }

        public override string Format { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
