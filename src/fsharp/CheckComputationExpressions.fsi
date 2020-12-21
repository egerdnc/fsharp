// Copyright (c) Microsoft Corporation.  All Rights Reserved.  See License.txt in the project root for license information.

module internal FSharp.Compiler.CheckComputationExpressions

open FSharp.Compiler.CheckExpressions
open FSharp.Compiler.Range
open FSharp.Compiler.SyntaxTree
open FSharp.Compiler.TypedTree

val TcSequenceExpressionEntry: cenv:TcFileState -> env:TcEnv -> overallTy:TType -> tpenv:UnscopedTyparEnv -> isArrayOrList:bool * isNotNakedRefCell:bool ref * comp:SynExpr -> m:Range -> Expr * UnscopedTyparEnv    

val TcArrayOrListSequenceExpression: cenv:TcFileState -> env:TcEnv -> overallTy:TType -> tpenv:UnscopedTyparEnv -> isArray:bool * comp:SynExpr -> m:Range -> Expr * UnscopedTyparEnv    

val TcComputationExpression: cenv:TcFileState -> env:TcEnv -> overallTy:TType -> tpenv:UnscopedTyparEnv -> mWhole:Range * interpExpr:Expr * builderTy:TType * comp:SynExpr -> Expr * UnscopedTyparEnv    

