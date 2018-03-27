using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class System_Runtime_CompilerServices_AsyncTaskMethodBuilder_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder);
            args = new Type[]{};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_0);
            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;                    
            foreach(var m in type.GetMethods())
            {
                if(m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }
                    lst.Add(m);
                }
            }
            args = new Type[]{typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("Start", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 1)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Start_1);

                        break;
                    }
                }
            }
            args = new Type[]{};
            method = type.GetMethod("get_Task", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Task_2);
            args = new Type[]{typeof(System.Runtime.CompilerServices.TaskAwaiter<ILRuntime.Runtime.Intepreter.ILTypeInstance>), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_3);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Exception)};
            method = type.GetMethod("SetException", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetException_4);
            args = new Type[]{};
            method = type.GetMethod("SetResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResult_5);
            args = new Type[]{typeof(System.Runtime.CompilerServices.IAsyncStateMachine)};
            method = type.GetMethod("SetStateMachine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetStateMachine_6);
            args = new Type[]{typeof(System.Runtime.CompilerServices.TaskAwaiter), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_7);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.WindUI.UIAssetLoader.LoaderRequest>), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_8);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(Core.IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitOnCompleted_9);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.AvatarLoaderRequest>), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_10);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.GameFlowLevelManager.LevelRequest>), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_11);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.SceneAssetLoader.SceneLoaderRequest>), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_12);

                        break;
                    }
                }
            }
            args = new Type[]{typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundles.ABLoader.LoaderRequest>), typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)};
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.GetParameters().Length == 2)
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_13);

                        break;
                    }
                }
            }

            app.RegisterCLRCreateDefaultInstance(type, () => new System.Runtime.CompilerServices.AsyncTaskMethodBuilder());


        }

        static void WriteBackInstance(ILRuntime.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, IList<object> __mStack, ref System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.AsyncTaskMethodBuilder[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* Create_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Start_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.Start<Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* get_Task_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            var result_of_this_method = instance_of_this_method.Task;

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AwaitUnsafeOnCompleted_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.TaskAwaiter<ILRuntime.Runtime.Intepreter.ILTypeInstance> @awaiter = (System.Runtime.CompilerServices.TaskAwaiter<ILRuntime.Runtime.Intepreter.ILTypeInstance>)typeof(System.Runtime.CompilerServices.TaskAwaiter<ILRuntime.Runtime.Intepreter.ILTypeInstance>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<ILRuntime.Runtime.Intepreter.ILTypeInstance>, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter<ILRuntime.Runtime.Intepreter.ILTypeInstance>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* SetException_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Exception @exception = (System.Exception)typeof(System.Exception).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetException(@exception);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* SetResult_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetResult();

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* SetStateMachine_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Runtime.CompilerServices.IAsyncStateMachine @stateMachine = (System.Runtime.CompilerServices.IAsyncStateMachine)typeof(System.Runtime.CompilerServices.IAsyncStateMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.SetStateMachine(@stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.TaskAwaiter @awaiter = (System.Runtime.CompilerServices.TaskAwaiter)typeof(System.Runtime.CompilerServices.TaskAwaiter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.TaskAwaiter<Framework.WindUI.UIAssetLoader.LoaderRequest> @awaiter = (System.Runtime.CompilerServices.TaskAwaiter<Framework.WindUI.UIAssetLoader.LoaderRequest>)typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.WindUI.UIAssetLoader.LoaderRequest>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<Framework.WindUI.UIAssetLoader.LoaderRequest>, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter<Framework.WindUI.UIAssetLoader.LoaderRequest>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* AwaitOnCompleted_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Core.IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter @awaiter = (Core.IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter)typeof(Core.IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitOnCompleted<Core.IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Core.IEnumeratorAwaitExtensions.SimpleCoroutineAwaiter[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.TaskAwaiter<Framework.AvatarLoaderRequest> @awaiter = (System.Runtime.CompilerServices.TaskAwaiter<Framework.AvatarLoaderRequest>)typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.AvatarLoaderRequest>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<Framework.AvatarLoaderRequest>, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter<Framework.AvatarLoaderRequest>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.TaskAwaiter<Framework.GameFlowLevelManager.LevelRequest> @awaiter = (System.Runtime.CompilerServices.TaskAwaiter<Framework.GameFlowLevelManager.LevelRequest>)typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.GameFlowLevelManager.LevelRequest>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<Framework.GameFlowLevelManager.LevelRequest>, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter<Framework.GameFlowLevelManager.LevelRequest>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.TaskAwaiter<Framework.SceneAssetLoader.SceneLoaderRequest> @awaiter = (System.Runtime.CompilerServices.TaskAwaiter<Framework.SceneAssetLoader.SceneLoaderRequest>)typeof(System.Runtime.CompilerServices.TaskAwaiter<Framework.SceneAssetLoader.SceneLoaderRequest>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<Framework.SceneAssetLoader.SceneLoaderRequest>, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter<Framework.SceneAssetLoader.SceneLoaderRequest>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor @stateMachine = (Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor)typeof(Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundles.ABLoader.LoaderRequest> @awaiter = (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundles.ABLoader.LoaderRequest>)typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundles.ABLoader.LoaderRequest>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder instance_of_this_method = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder)typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));

            instance_of_this_method.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundles.ABLoader.LoaderRequest>, Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor>(ref @awaiter, ref @stateMachine);

            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = stateMachine;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, stateMachine);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = stateMachine;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, stateMachine);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Framework.Hotfix.IAsyncStateMachineAdaptor.Adaptor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = stateMachine;
                    }
                    break;
            }

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = *(StackObject**)&ptr_of_this_method->Value;
                        object ___obj = awaiter;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, awaiter);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = awaiter;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, awaiter);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AssetBundles.ABLoader.LoaderRequest>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = awaiter;
                    }
                    break;
            }

            return __ret;
        }



    }
}