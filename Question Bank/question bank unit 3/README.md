## Short Questions [1 Mark]
**1. Design View:**

-   **Primary Window:** The main design window, also known as the **Form Designer** or **Visual Studio Designer**, is typically used to visually create and edit the user interface (UI) of your program.
-   **Alternate Window:** Some development environments may offer a separate **Design** or **UI Designer** window specifically dedicated to UI creation.

**2. Properties Window:**

-   The Properties window allows you to **view and modify the properties** of various controls and objects within your project. These properties define the appearance, behavior, and functionality of those elements.

**3. Properties Window Shortcut Key:**

-   Frequently used shortcut key: **F4** (in many development environments)
-   Alternative shortcut keys may exist and vary depending on your specific environment.

**4. Input Controls:**

-   Input controls are UI elements that enable users to **enter data, make selections, or interact** with your program. They play a crucial role in collecting input and user interaction.

**5. Examples of Input Controls:**

-   TextBox: Used for single-line text input.
-   PasswordBox: Used for masked text input (e.g., passwords).
-   CheckBox: Used for selecting one or more options from a set.
-   RadioButton: Used for selecting only one option from a mutually exclusive set.
-   ComboBox: Used for selecting an option from a predefined list, often with the ability to enter custom values.
-   ListBox: Used for displaying and selecting multiple options from a list, often with the ability to scroll through the content.
-   Button: Used to trigger actions when clicked.

**6. Label Control Properties:**

-   **Text:** The text displayed by the label.
-   **Font:** The font style and size of the text.
-   **ForeColor:** The color of the text.
-   **AutoSize:** Determines whether the label automatically resizes its height to fit the displayed text (True) or maintains a fixed height (False).
-   **TextAlign:** Controls the alignment of the text within the label (e.g., left, right, center).
-   **Enabled:** Specifies whether the label is enabled and can interact with the user (True) or disabled and visually inactive (False).
-   **Visible:** Determines whether the label is visible on the form (True) or hidden (False).

**7. AutoSize Property Effect:**

-   **True:** The label's height will automatically adjust to accommodate all the text it contains, ensuring full visibility.
-   **False:** The label will maintain the height you set, potentially truncating the text if it doesn't fit within the defined size.

**8. Multiline Textbox:**

-   **Multiline** property: Set to `True` to allow the textbox to display multiple lines of text.

**9. RadioButton Selection:**

-   **Checked** property: Set to `True` to select a specific RadioButton.

**10. Checkbox Selection:**

-   **Checked** property: Set to `True` to select a Checkbox.
Here's the response to the questions, combining the best aspects of previous responses and addressing identified issues:

**11. CheckState Property (CheckBox Control):**

The `CheckState` property of a CheckBox control determines its current state:

-   **Checked:** The checkbox is selected and displays a checkmark (`True`).
-   **Unchecked:** The checkbox is not selected and does not display a checkmark (`False`).
-   **Indeterminate:** This state is only available for tri-state checkboxes and indicates an intermediate, neither fully checked nor unchecked, state (`System.Windows.Forms.CheckState.Indeterminate`).

**12. ListBox Control Properties:**

Here are four common properties of ListBox controls:

-   **Items:** A collection that stores the individual items displayed in the list box.
-   **SelectedIndex:** Gets or sets the zero-based index of the currently selected item.
-   **SelectedIndices:** A collection containing the zero-based indexes of all currently selected items (for multi-selection list boxes).
-   **SelectedItem:** Gets or sets the currently selected item (if single-selection is allowed).

**13. Adding Items to ListBox:**

You can add items to the ListBox using the `Items` property in several ways:

-   **At design time:** Edit the `Items` property directly in the Properties window, entering each item on a new line.
-   **At runtime:** Use code, typically within your program or event handlers, to add items dynamically using methods like `AddItem`, `AddRange`, or by setting individual elements of the `Items` collection.

**14. Displaying Selected Items:**

There are two primary ways to display selected items in a ListBox:

-   **Visually:** The selected item(s) in a ListBox are typically highlighted or displayed with a different background color for easier identification.
-   **Programmatically:** You can access the selected item(s) using properties like `SelectedItem`, `SelectedItems`, or `SelectedIndex` to retrieve their values or perform further actions based on the selection.

**15. SelectedIndex Property:**

The `SelectedIndex` property of a ListBox returns the zero-based index of the currently **single** selected item. If no item is selected, it returns -1. This property allows you to programmatically identify, manage, or interact with the selected item based on its position within the list.

**16. PictureBox Control Properties:**

Here are four common properties of PictureBox controls:

-   **Image:** The image displayed within the PictureBox. Can be set by providing an image object or loading an image file.
-   **SizeMode:** Determines how the image is resized to fit within the PictureBox boundaries (e.g., Stretch, CenterImage, Zoom).
-   **BorderStyle:** Controls whether the PictureBox displays a border and its style (e.g., None, FixedSingle, Fixed3D).
-   **Size:** Sets the width and height of the PictureBox control.

**17. Hiding Image in PictureBox:**

-   **Visible:** Set this property of the PictureBox control to `False` on the button click event to hide the image.

**18. SizeMode Property (PictureBox):**

The `SizeMode` property of a PictureBox control determines how an image is resized to fit within the PictureBox's boundaries. Here are some common options:

-   **Normal:** Displays the image at its original size, potentially causing it to be clipped if it exceeds the PictureBox's dimensions.
-   **Stretch:** Stretches the image to fit the entire PictureBox area, potentially distorting the aspect ratio.
-   **CenterImage:** Centers the image within the PictureBox, potentially leaving empty space around the image if it's smaller than the PictureBox.
-   **Zoom:** Zooms the image to fill the entire PictureBox while maintaining the aspect ratio, potentially cropping parts of the image if necessary.
-   **AutoSize:** Automatically resizes the PictureBox to fit the dimensions of the loaded image.

**19. Timer Control Properties:**

Here are four common properties of Timer controls:

-   **Enabled:** Determines whether the timer is currently running (True) or stopped (False).
-   **Interval:** Sets the time interval (in milliseconds) between timer ticks.
-   **Start():** Starts the timer, triggering the `Tick` event at regular intervals.
-   **Stop():** Stops the timer, preventing further `Tick` events until restarted.

**20. Opening and Manipulating Forms:**

You can open and manipulate forms using the following statements:

-   **`Form formName = new Form();`**: This creates a new instance of a form named `formName`.
-   **`formName.Show();`**: This displays the newly created form on the screen.
-   **`formName.Close();`**: This closes the form, removing it from the screen.
-   **`formName.Text = "New Title";`**: This sets the title of the form.
-   **`formName.Location = new Point(x, y);`**: This sets the position of the form on the screen (x represents horizontal position, y represents vertical position).

**21. Positioning Forms:**

The **`Location`** property is used for positioning each form in your project. This property holds a `Point` object that specifies the form's coordinates (X and Y) relative to the top-left corner of the screen.

**22. StartPosition Properties:**

Here are the five `StartPosition` properties you can use to position a form on the Windows desktop:

-   **Manual:** The form appears at the location specified by the `Location` property.
-   **CenterScreen:** The form appears centered horizontally and vertically on the screen.
-   **CenterParent:** The form appears centered relative to its parent form (if displayed as a modal dialog).
-   **WindowsDefaultLocation:** The form appears at the default location determined by the system settings.
-   **WindowsDefaultBounds:** The form appears with the size and location determined by the system settings.


**23. Setting Size and Position of a Startup Form:**

Here are two common approaches to set the size and position of a startup form on the Windows desktop:

**1. Using Properties:**

-   Set the **`Size`** property of the form in the designer by dragging the form's edges or entering the desired width and height in pixels.
-   Set the **`Location`** property of the form in the designer or by code to specify its coordinates (X and Y) relative to the top-left corner of the screen.

**2. Using `StartPosition` Property:**

-   Set the **`StartPosition`** property of the form in the designer or by code to one of the pre-defined positions:
    -   **`CenterScreen`**: Centers the form on the screen.
    -   **`Manual`**: Uses the existing `Size` and `Location` properties.
    -   **`WindowsDefaultLocation`**: Positions the form at the system's default location.
    -   **`WindowsDefaultBounds`**: Positions the form at the system's default location and size.

**24. TabIndex Property:**

The **`TabIndex`** property of a control determines the **tabbing order** of controls on a form. When a user presses the Tab key, focus moves from one control to the next in the order defined by their `TabIndex` values (lowest to highest). This property helps users navigate the form using the keyboard efficiently.

**25. Anchor Property:**

The **`Anchor`** property of a control allows you to **dock** it to the edges and sides of its container (usually a form). When the container resizes, the control automatically adjusts its position based on the anchored edges. This helps maintain the layout of your form across different screen resolutions.

**26. MDI (Multiple Document Interface):**

MDI (Multiple Document Interface) is a window management technique where a **parent form** can contain and manage multiple **child forms** within a single application window. The parent form typically provides a common user interface like menus and toolbars, while each child form acts as a separate document window within the application.

**27. Steps to Run a Visual Program:**

1.  **Compile the code:** This translates your program's code into a machine-readable format (executable file) that the operating system can understand. Your development environment usually provides a "Build" or "Compile" option to do this.
2.  **Run the executable:** Once compiled, locate the generated executable file (typically with a `.exe` extension) and double-click it to execute the program. You can also run it from the command line or your development environment's "Run" or "Debug" options.

## long Questions [5 Mark]


1.Write a note on Gathering input controls.
## Gathering Input Controls: Essential Elements of User Interaction

**Input controls** are the building blocks for **collecting information and user interactions** within your application. They serve as bridges between users and your program, allowing users to provide data, make selections, and interact with the application's functionalities.

**Key characteristics of input controls:**

* **Variety of types:** Different control types cater to specific data types and interaction styles. 
    * **Text boxes:** For single-line text input.
    * **Password boxes:** For masked text input, like passwords.
    * **Checkboxes:** For selecting one or multiple options.
    * **Radio buttons:** For selecting only one option from a mutually exclusive set.
    * **Combo boxes:** For selecting an option from a predefined list, often with the ability to enter custom values.
    * **List boxes:** For displaying and selecting multiple options from a list.
    * **Buttons:** For triggering actions when clicked.
    * Many more specialized controls exist for various purposes.
* **User-friendliness:** Well-designed input controls should be **intuitive and easy to use**. They should provide clear instructions and visually indicate their purpose through labels and proper placement.
* **Data validation:** It's essential to implement appropriate **validation mechanisms** to ensure the entered data meets the expected format, range, or type. This helps prevent errors and improves data integrity.
* **Accessibility:** Consider **accessibility guidelines** when choosing and designing input controls. Controls should be usable by people with disabilities, such as providing alternative input methods for users with limited mobility or keyboard access.

**Effective use of input controls:**

* **Matching the control type to the data:** Choose the most suitable control type based on the expected data format and user interaction needed.
* **Clear labeling:** Provide descriptive labels that clearly explain the purpose of each control, aiding user understanding.
* **Meaningful placement:** Arrange controls logically and intuitively within the user interface, guiding users through the information gathering process.
* **Feedback mechanisms:** Provide feedback to users when they interact with controls, such as visual cues to acknowledge selections or error messages for invalid input.

**By carefully selecting, designing, and using input controls, you can create user-friendly and efficient applications that effectively collect and utilize user input.**

--

1. List  out  the  input  controls.  Explain  any  three  in  brief  and  list  at  least  three  properties  of  each 
control.

**Common Input Controls:**

1. **Text Box:**
    - **Purpose:** Used for single-line text input.
    - **Properties:**
        - `Text`: Stores the currently entered text.
        - `MaxLength`: Limits the maximum number of characters allowed.
        - `Multiline`: Enables or disables multi-line input (usually set to `False`).

2. **Password Box:**
    - **Purpose:** Used for masked text input, commonly used for passwords.
    - **Properties:**
        - `Text`: Stores the currently entered password (displayed as asterisks or other masking characters).
        - `PasswordChar`: Sets the character used to mask the entered text (defaults to '*').
        - `MaxLength`: Limits the maximum number of characters allowed.

3. **CheckBox:**
    - **Purpose:** Used for selecting one or more options from a set, where each option can be independently selected or deselected.
    - **Properties:**
        - `Checked`: Determines whether the checkbox is currently selected (`True`) or not (`False`).
        - `Text`: The label displayed next to the checkbox, describing the option.
        - `Enabled`: Controls whether the checkbox is interactive (`True`) or disabled (`False`).

4. **RadioButton:**
    - **Purpose:** Used for selecting only one option from a mutually exclusive set. Only one radio button within a group can be selected at a time.
    - **Properties:**
        - `Checked`: Determines whether the radio button is currently selected (`True`) or not (`False`).
        - `Text`: The label displayed next to the radio button, describing the option.
        - `GroupName`: Assigns the radio button to a specific group, ensuring only one within that group can be selected.

5. **Combo Box:**
    - **Purpose:** Combines a text box and a drop-down list, allowing users to select from a predefined list of options or enter a custom value.
    - **Properties:**
        - `Text`: Holds the currently selected item, displayed in the text box portion.
        - `Items`: A collection containing all the available options for selection in the drop-down list.
        - `DropDownStyle`: Determines how the drop-down list is displayed (e.g., `DropDownList`, `DropDown`).

6. **List Box:**
    - **Purpose:** Used for displaying and selecting multiple options from a list. Users can select one or more items simultaneously.
    - **Properties:**
        - `Items`: A collection containing all the available options displayed in the list box.
        - `SelectedIndex`: Gets or sets the zero-based index of the currently selected item (if single-selection is allowed).
        - `SelectedIndices`: Gets a collection containing the zero-based indexes of all currently selected items (for multi-selection list boxes).

7. **Button:**
    - **Purpose:** Used to trigger actions when clicked. Can initiate functions, open new forms, submit data, etc.
    - **Properties:**
        - `Text`: The text displayed on the button, indicating its purpose.
        - `Enabled`: Controls whether the button is interactive (`True`) or disabled (`False`).
        - `Click`: An event that occurs when the button is clicked, allowing you to link it to specific code execution.

---
2. What is the use of Label control? List and explain at least three properties with example. 
Absolutely! Here's an explanation of the Label control, its uses, and several properties with examples:

**The Label Control: Purpose**

The Label control in Visual Basic is primarily used to **display static text** on a form. Unlike textboxes, labels are not directly editable by the user. They provide a way to:

* **Label other controls:** Place labels near text boxes, buttons, etc., to explain their purpose.
* **Display instructions:** Provide guidance to the user on how to interact with the form.
* **Show output or information:** Display calculated values, results, messages, etc.

**Key Properties and Examples**

1. **Text:**
   - **Purpose:** The most fundamental property; it holds the text that you want the label to display.
   - **Example:** 
     ```vb.net
     Label1.Text = "Hello, World!"
     ```

2. **Font:** 
   - **Purpose:** Allows you to control the font style, size, and appearance of the label's text.
   - **Example:**
     ```vb.net
     Label1.Font = New Font("Arial", 12, FontStyle.Bold)
     ```

3. **AutoSize:**
    - **Purpose:** A Boolean property that determines whether the label will automatically resize itself to fit the text (True), or maintain a fixed size, potentially truncating the text if it exceeds the bounds (False).
    - **Example:**
      ```vb.net
      ' AutoSize = True (Default) - Label resizes to fit the text
      Label1.Text = "This is a potentially long string of text." 

      ' AutoSize = False - Label maintains fixed size
      Label1.AutoSize = False  
      ```

**Additional Important Properties**

* **ForeColor:** Controls the text color of the label.
* **TextAlign:** Sets the alignment of the text within the label's boundaries (e.g., Left, Right, Center).
* **Image:** Sets an image to be displayed within the label along with or instead of text.


---
3. Explain ListBox and ComboBox control with at least two properties. 
Here's a breakdown of ListBox and ComboBox controls, along with at least two of their key properties:

**ListBox**

* **Purpose:** Presents a scrollable list of items from which users can select one or multiple entries. Ideal for displaying a moderate number of choices.

* **Properties:**

    1.  **Items:** A collection that stores the individual items displayed within the list box. You can add items at design time or programmatically using `Items.Add` or `Items.AddRange`.
    2. **SelectionMode:** Controls how many items a user can select. Options include:
        * `None`: No selection allowed.
        * `One`: Only one item can be selected at a time.
        * `MultiSimple`: Multiple items can be selected using the mouse and keyboard.
        * `MultiExtended`: Multiple items can be selected with more flexible control using Ctrl/Shift + clicks.

**ComboBox**

* **Purpose:** Combines a text box and a drop-down list. It allows users to either select an item from a predefined list or enter a custom value. Great for situations where you want to offer a list of suggestions but also enable some flexibility.

* **Properties:**

    1. **Items:** Similar to the ListBox, the `Items` collection stores the options displayed in the drop-down list.
    2. **DropDownStyle:** Determines the display style of the combo box:
        * `Simple`:  A text box and list that is always visible.
        * `DropDown`: (Default) A text box with a drop-down arrow; only the list appears when the arrow is clicked.
        * `DropDownList`: A text box with a drop-down arrow; the user can only select from the list and cannot enter custom values. 


---
4. State significance of following properties of the controls:
i. “passwordchar” property of TextBox.
ii. “default” property of command button.
iii. “style” property of CheckBox button.
iv. “multiselect” property of listbox.
v. “listindex” property of listbox.

## Significance of Control Properties:

Here's a breakdown of the significance of the mentioned control properties:

**i. `passwordchar` Property of TextBox:**

- **Purpose:** Controls the character displayed to mask the actual text entered in a password box.
- **Significance:** Enhances security by hiding the actual password characters from onlookers. It provides visual feedback and prevents users from accidentally revealing their passwords while typing. 

**ii. `default` Property of Command Button:**

- **Purpose:** Specifies the button that is triggered by pressing the Enter key or using the default action setting in certain dialog boxes.
- **Significance:**
    - Improves user experience by simplifying interaction.
    - Users can press Enter instead of clicking the mouse, making the process faster and more efficient.
    - It provides a clear indication of the primary action associated with the form or dialog.

**iii. `style` Property of CheckBox Button:**

- **Purpose:** Determines the visual appearance of a CheckBox.
- **Significance:**
    - Offers variety in representing the checkbox state (checked, unchecked, indeterminate).
    - Allows customization to match the overall design aesthetic of your application.
    - Examples of `style` options include `Flat`, `RadioButton`, and `CheckBox`.

**iv. `multiselect` Property of ListBox:**

- **Purpose:** Controls whether users can select multiple items from the list box.
- **Significance:**
    - Enables selecting multiple options if required by the functionality of your application.
    - Provides flexibility to users in situations where they need to choose more than one item.

**v. `listindex` Property of ListBox:**

- **Purpose:** Gets or sets the zero-based index of the currently selected item in a single-selection list box.
- **Significance:**
    - Allows programmatic access to the selected item's index, facilitating further actions based on the selection.
    - Enables you to work with the selected item, such as retrieving its text or value, or performing operations based on its position in the list.

---
5. What is the use of Picture Box control? List and explain at least three properties with example.
Absolutely! Here's an explanation of the PictureBox control, its purpose, and several properties with examples:

**Purpose of the PictureBox Control**

The PictureBox control in Visual Basic is specifically designed to display images within your forms. It's a versatile control that supports various image formats, including:

* **BMP** (Bitmaps)
* **JPEG** (Joint Photographic Experts Group)
* **GIF** (Graphics Interchange Format)
* **PNG** (Portable Network Graphics)
* **Icons** 

**Key Properties and Examples**

1. **Image:**
   - **Purpose:** The most important property; it holds the image to be displayed within the PictureBox. You can set it at design time or load an image dynamically at runtime using code.
   - **Example:**
      ```vb.net
      ' Load from file:
      PictureBox1.Image = Image.FromFile("C:\Images\MyPicture.jpg") 

      ' Load from project resources: 
      PictureBox1.Image = My.Resources.SampleImage 
      ```

2. **SizeMode:**
    - **Purpose:** Controls how the image is resized to fit within the bounds of the PictureBox. This property has several options:
        * `Normal`: Displays the image at its original size, potentially cropping it if it doesn't fit the PictureBox dimensions.
        * `StretchImage`: Stretches or shrinks the image to fit the PictureBox entirely, potentially distorting the aspect ratio.
        * `AutoSize`: Automatically resizes the PictureBox to accommodate the image's original dimensions.
        * `CenterImage`: Centers the image within the PictureBox (no resizing), potentially leaving empty space.
        * `Zoom`: Zooms the image to fill the PictureBox, maintaining aspect ratio, and cropping if necessary.
    - **Example:**
      ```vb.net
      PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage 
      ```

3. **BorderStyle:**
    - **Purpose:** Determines the appearance of the border around the PictureBox.
    - **Options:**
        * `None`: No border.
        * `FixedSingle`: A thin, single-line border.
        * `Fixed3D`: A three-dimensional border.
    - **Example:**
      ```vb.net
      PictureBox1.BorderStyle = BorderStyle.Fixed3D 
      ```

---

