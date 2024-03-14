
## Post Laboratory questions

1. Difference between KeyDown, KeyPress, and KeyUp events:
   - **KeyDown**: Occurs when a key is pressed down on the keyboard. This event is useful for detecting when a key is being held down, but it does not provide information about the character that was pressed.
   - **KeyPress**: Occurs when a key is pressed and released, and a character is generated. This event is useful for detecting when a key is pressed and a character is entered.
   - **KeyUp**: Occurs when a key is released after being pressed. This event is useful for detecting when a key is released, but it does not provide information about the character that was pressed.

Example:

```csharp
private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
{
 
    if (!char.IsDigit(e.KeyChar))
    {
        e.Handled = true; 
    }
}
```

2. TextChanged event of TextBox:
   The TextChanged event occurs when the text in a TextBox control changes. This event is useful for updating other controls or performing other actions when the text in the TextBox changes.

Example:

```csharp
private void TextBox_TextChanged(object sender, EventArgs e)
{
    label1.Text = textBox1.Text;
}
```

3. CheckStateChanged property:
   The CheckStateChanged property is not an event, but rather a property that is raised when the CheckState of a CheckBox or RadioButton control changes. This property is useful for updating other controls or performing other actions when the CheckState of the control changes.

4. CheckedChanged event of RadioButton and CheckBox:
   The CheckedChanged event occurs when the checked property of a radio button or checkbox control changes. This event is useful for updating other controls or performing other actions when the CheckState of the control changes.

Example:

```csharp
private void CheckBox_CheckedChanged(object sender, EventArgs e)
{
    if (((CheckBox)sender).Checked)
    {
        MessageBox.Show("CheckBox is checked");
    }
}
```

5. SelectedIndexChanged event of ComboBox and ListBox:
   The SelectedIndexChanged event occurs when the selected item in a ComboBox or ListBox control changes. This event is useful for updating other controls or performing other actions when the selected item changes.

Example:

```csharp
private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
{ 
    string selectedItem = ((ComboBox)sender).SelectedItem.ToString();
    if (selectedItem == "Option 1")
    {
        MessageBox.Show("Option 1 selected");
    }
}
```

For ListBox:

```csharp
private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
{ 
    string selectedItem = ((ListBox)sender).SelectedItem.ToString();
    if (selectedItem == "Option 1")
    {
        MessageBox.Show("Option 1 selected");
    }
}
```
