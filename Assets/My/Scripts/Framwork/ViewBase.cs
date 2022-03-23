using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//视图类：
//1、每个类都有自己的名字
//2、每个类都注册自己关系的视角，并且处理该事件，比如"AttackEvent"、
public abstract class ViewBase : MonoBehaviour  //抽象类相当于制定了一个模板，规范
{
    public abstract string Name { get; }

    public virtual void F() { }

    public abstract void G();
}
public class MainView : ViewBase
{
    public override string Name
    {
        get { return "MainView"; }
    }

    public override void G()
    {
        this.F();
        throw new System.NotImplementedException();
    }
}
