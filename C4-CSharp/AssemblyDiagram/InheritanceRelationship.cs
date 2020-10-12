﻿namespace C4_CSharp.AssemblyDiagram
{
    public class InheritanceRelationship : Relationship
    {
        public InheritanceRelationship(TypeNameText baseTypeName, TypeNameText subTypeName): base(baseTypeName, subTypeName, "<|--", baseTypeName.TypeArguments)
        {          
        }
    }
}