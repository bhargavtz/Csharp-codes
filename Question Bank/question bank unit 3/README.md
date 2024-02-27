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
