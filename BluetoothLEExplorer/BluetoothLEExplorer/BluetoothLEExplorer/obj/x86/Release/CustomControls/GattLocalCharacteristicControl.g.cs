﻿#pragma checksum "C:\Users\tilt7\Documents\GitHub\BluetoothLEExplorer\BluetoothLEExplorer\BluetoothLEExplorer\CustomControls\GattLocalCharacteristicControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "921D0FDCD0625E404D59695BB1978551"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BluetoothLEExplorer.CustomControls
{
    partial class GattLocalCharacteristicControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_ContentControl_Content(global::Windows.UI.Xaml.Controls.ContentControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.Content = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Boolean) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Boolean), targetNullValue);
                }
                obj.IsChecked = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBox_IsReadOnly(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.Boolean value)
            {
                obj.IsReadOnly = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class GattLocalCharacteristicControl_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGattLocalCharacteristicControl_Bindings
        {
            private global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.StackPanel obj2;
            private global::Windows.UI.Xaml.Controls.Button obj3;
            private global::Windows.UI.Xaml.Controls.CheckBox obj4;
            private global::Windows.UI.Xaml.Controls.CheckBox obj5;
            private global::Windows.UI.Xaml.Controls.CheckBox obj6;
            private global::Windows.UI.Xaml.Controls.CheckBox obj7;
            private global::Windows.UI.Xaml.Controls.CheckBox obj8;
            private global::Windows.UI.Xaml.Controls.TextBox obj9;
            private global::Windows.UI.Xaml.Controls.TextBox obj10;

            // Fields for each event bindings event handler.
            private global::Windows.UI.Xaml.RoutedEventHandler obj3Click;

            private GattLocalCharacteristicControl_obj1_BindingsTracking bindingsTracking;

            public GattLocalCharacteristicControl_obj1_Bindings()
            {
                this.bindingsTracking = new GattLocalCharacteristicControl_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // CustomControls\GattLocalCharacteristicControl.xaml line 25
                        this.obj2 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                        break;
                    case 3: // CustomControls\GattLocalCharacteristicControl.xaml line 44
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Button)target;
                        this.obj3Click = (global::System.Object p0, global::Windows.UI.Xaml.RoutedEventArgs p1) =>
                        {
                            this.dataRoot.Characteristic.Characteristic.NotifyValue();
                        };
                        ((global::Windows.UI.Xaml.Controls.Button)target).Click += obj3Click;
                        break;
                    case 4: // CustomControls\GattLocalCharacteristicControl.xaml line 37
                        this.obj4 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_4(this.obj4);
                        break;
                    case 5: // CustomControls\GattLocalCharacteristicControl.xaml line 38
                        this.obj5 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 6: // CustomControls\GattLocalCharacteristicControl.xaml line 39
                        this.obj6 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_6(this.obj6);
                        break;
                    case 7: // CustomControls\GattLocalCharacteristicControl.xaml line 40
                        this.obj7 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_7(this.obj7);
                        break;
                    case 8: // CustomControls\GattLocalCharacteristicControl.xaml line 41
                        this.obj8 = (global::Windows.UI.Xaml.Controls.CheckBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_8(this.obj8);
                        break;
                    case 9: // CustomControls\GattLocalCharacteristicControl.xaml line 33
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_9(this.obj9);
                        break;
                    case 10: // CustomControls\GattLocalCharacteristicControl.xaml line 27
                        this.obj10 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_10(this.obj10);
                        break;
                    default:
                        break;
                }
            }

            // IGattLocalCharacteristicControl_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_ShowValue(obj.ShowValue, phase);
                        this.Update_NotifyButtonText(obj.NotifyButtonText, phase);
                        this.Update_NotifyButtonVisibility(obj.NotifyButtonVisibility, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Characteristic(obj.Characteristic, phase);
                        this.Update_Value(obj.Value, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_IsReadOnly(obj.IsReadOnly, phase);
                    }
                }
                else
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.UpdateFallback_Value(phase);
                    }
                }
            }
            private void Update_ShowValue(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 25
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj2, obj);
                }
            }
            private void Update_NotifyButtonText(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 44
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ContentControl_Content(this.obj3, obj, null);
                }
            }
            private void Update_NotifyButtonVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 44
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, obj);
                }
            }
            private void Update_Characteristic(global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_Characteristic(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Characteristic_HasReadDescriptor(obj.HasReadDescriptor, phase);
                        this.Update_Characteristic_HasWriteDescriptor(obj.HasWriteDescriptor, phase);
                        this.Update_Characteristic_HasWriteWithoutResponseDescriptor(obj.HasWriteWithoutResponseDescriptor, phase);
                        this.Update_Characteristic_HasNotifyDescriptor(obj.HasNotifyDescriptor, phase);
                        this.Update_Characteristic_HasIndicateDescriptor(obj.HasIndicateDescriptor, phase);
                        this.Update_Characteristic_UserDescription(obj.UserDescription, phase);
                    }
                }
            }
            private void Update_Characteristic_HasReadDescriptor(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 37
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj4, obj, null);
                }
            }
            private void Update_Characteristic_HasWriteDescriptor(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 38
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj5, obj, null);
                }
            }
            private void Update_Characteristic_HasWriteWithoutResponseDescriptor(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 39
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj6, obj, null);
                }
            }
            private void Update_Characteristic_HasNotifyDescriptor(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 40
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj7, obj, null);
                }
            }
            private void Update_Characteristic_HasIndicateDescriptor(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 41
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj8, obj, null);
                }
            }
            private void Update_Characteristic_UserDescription(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 33
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj9, obj, null);
                }
            }
            private void Update_Value(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 27
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj10, obj, null);
                }
            }
            private void Update_IsReadOnly(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 27
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_IsReadOnly(this.obj10, obj);
                }
            }

            private void UpdateFallback_Value(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // CustomControls\GattLocalCharacteristicControl.xaml line 27
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj10, "blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah blah ", null);
                }
            }
            private void UpdateTwoWay_4_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.Characteristic != null)
                        {
                            this.dataRoot.Characteristic.HasReadDescriptor = (global::System.Boolean)this.obj4.IsChecked;
                        }
                    }
                }
            }
            private void UpdateTwoWay_5_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.Characteristic != null)
                        {
                            this.dataRoot.Characteristic.HasWriteDescriptor = (global::System.Boolean)this.obj5.IsChecked;
                        }
                    }
                }
            }
            private void UpdateTwoWay_6_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.Characteristic != null)
                        {
                            this.dataRoot.Characteristic.HasWriteWithoutResponseDescriptor = (global::System.Boolean)this.obj6.IsChecked;
                        }
                    }
                }
            }
            private void UpdateTwoWay_7_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.Characteristic != null)
                        {
                            this.dataRoot.Characteristic.HasNotifyDescriptor = (global::System.Boolean)this.obj7.IsChecked;
                        }
                    }
                }
            }
            private void UpdateTwoWay_8_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.Characteristic != null)
                        {
                            this.dataRoot.Characteristic.HasIndicateDescriptor = (global::System.Boolean)this.obj8.IsChecked;
                        }
                    }
                }
            }
            private void UpdateTwoWay_9_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.Characteristic != null)
                        {
                            this.dataRoot.Characteristic.UserDescription = this.obj9.Text;
                        }
                    }
                }
            }
            private void UpdateTwoWay_10_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        this.dataRoot.Value = this.obj10.Text;
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class GattLocalCharacteristicControl_obj1_BindingsTracking
            {
                private global::System.WeakReference<GattLocalCharacteristicControl_obj1_Bindings> weakRefToBindingObj; 

                public GattLocalCharacteristicControl_obj1_BindingsTracking(GattLocalCharacteristicControl_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<GattLocalCharacteristicControl_obj1_Bindings>(obj);
                }

                public GattLocalCharacteristicControl_obj1_Bindings TryGetBindingObject()
                {
                    GattLocalCharacteristicControl_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_Characteristic(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    GattLocalCharacteristicControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl obj = sender as global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Characteristic(obj.Characteristic, DATA_CHANGED);
                                bindings.Update_Value(obj.Value, DATA_CHANGED);
                            }
                            else
                            {
                                bindings.UpdateFallback_Value(DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "Characteristic":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Characteristic(obj.Characteristic, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Value":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Value(obj.Value, DATA_CHANGED);
                                    }
                                    else
                                    {
                                        bindings.UpdateFallback_Value(DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void DependencyPropertyChanged_Characteristic(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    GattLocalCharacteristicControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl obj = sender as global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl;
                        if (obj != null)
                        {
                            bindings.Update_Characteristic(obj.Characteristic, DATA_CHANGED);
                        }
                    }
                }
                private long tokenDPC_Characteristic = 0;
                public void UpdateChildListeners_(global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl obj)
                {
                    GattLocalCharacteristicControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl.CharacteristicProperty, tokenDPC_Characteristic);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                            tokenDPC_Characteristic = obj.RegisterPropertyChangedCallback(global::BluetoothLEExplorer.CustomControls.GattLocalCharacteristicControl.CharacteristicProperty, DependencyPropertyChanged_Characteristic);
                        }
                    }
                }
                public void PropertyChanged_Characteristic(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    GattLocalCharacteristicControl_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel obj = sender as global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_Characteristic_HasReadDescriptor(obj.HasReadDescriptor, DATA_CHANGED);
                                bindings.Update_Characteristic_HasWriteDescriptor(obj.HasWriteDescriptor, DATA_CHANGED);
                                bindings.Update_Characteristic_HasWriteWithoutResponseDescriptor(obj.HasWriteWithoutResponseDescriptor, DATA_CHANGED);
                                bindings.Update_Characteristic_HasNotifyDescriptor(obj.HasNotifyDescriptor, DATA_CHANGED);
                                bindings.Update_Characteristic_HasIndicateDescriptor(obj.HasIndicateDescriptor, DATA_CHANGED);
                                bindings.Update_Characteristic_UserDescription(obj.UserDescription, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "HasReadDescriptor":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Characteristic_HasReadDescriptor(obj.HasReadDescriptor, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "HasWriteDescriptor":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Characteristic_HasWriteDescriptor(obj.HasWriteDescriptor, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "HasWriteWithoutResponseDescriptor":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Characteristic_HasWriteWithoutResponseDescriptor(obj.HasWriteWithoutResponseDescriptor, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "HasNotifyDescriptor":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Characteristic_HasNotifyDescriptor(obj.HasNotifyDescriptor, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "HasIndicateDescriptor":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Characteristic_HasIndicateDescriptor(obj.HasIndicateDescriptor, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "UserDescription":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_Characteristic_UserDescription(obj.UserDescription, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel cache_Characteristic = null;
                public void UpdateChildListeners_Characteristic(global::BluetoothLEExplorer.ViewModels.GenericGattCharacteristicViewModel obj)
                {
                    if (obj != cache_Characteristic)
                    {
                        if (cache_Characteristic != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_Characteristic).PropertyChanged -= PropertyChanged_Characteristic;
                            cache_Characteristic = null;
                        }
                        if (obj != null)
                        {
                            cache_Characteristic = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_Characteristic;
                        }
                    }
                }
                public void RegisterTwoWayListener_4(global::Windows.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_4_IsChecked();
                        }
                    });
                }
                public void RegisterTwoWayListener_5(global::Windows.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_IsChecked();
                        }
                    });
                }
                public void RegisterTwoWayListener_6(global::Windows.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_6_IsChecked();
                        }
                    });
                }
                public void RegisterTwoWayListener_7(global::Windows.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_7_IsChecked();
                        }
                    });
                }
                public void RegisterTwoWayListener_8(global::Windows.UI.Xaml.Controls.CheckBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_8_IsChecked();
                        }
                    });
                }
                public void RegisterTwoWayListener_9(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_9_Text();
                        }
                    };
                }
                public void RegisterTwoWayListener_10(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.LostFocus += (sender, e) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_10_Text();
                        }
                    };
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 4: // CustomControls\GattLocalCharacteristicControl.xaml line 37
                {
                    this.cbRead = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 5: // CustomControls\GattLocalCharacteristicControl.xaml line 38
                {
                    this.cbWrite = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 6: // CustomControls\GattLocalCharacteristicControl.xaml line 39
                {
                    this.cbWriteWOResponds = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 7: // CustomControls\GattLocalCharacteristicControl.xaml line 40
                {
                    this.cbNotify = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 8: // CustomControls\GattLocalCharacteristicControl.xaml line 41
                {
                    this.cbIndicate = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 9: // CustomControls\GattLocalCharacteristicControl.xaml line 33
                {
                    this.descText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10: // CustomControls\GattLocalCharacteristicControl.xaml line 27
                {
                    this.ValueText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // CustomControls\GattLocalCharacteristicControl.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    GattLocalCharacteristicControl_obj1_Bindings bindings = new GattLocalCharacteristicControl_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

