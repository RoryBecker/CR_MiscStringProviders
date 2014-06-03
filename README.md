CR_MiscStringProviders
======================

As the title, this project is home to some Misc StringProviders. 

**RemoveSpaces**

The RemoveSpaces StringProvider is intended to be used in template from within a TextLink  

	<asp:Button ID="cmd«TextLink(Button,RemoveSpaces)»" runat=server" Text="«Caret»«TextLink(Button)»«BlockAnchor»" />

The important pieces here are:

	«TextLink(Button)»    // Text entered here

and 

	«TextLink(Button,RemoveSpaces)»    // Processed copy of Text emitted here.

As the pseudo comments above indicate, the first of these is used to accept textual entry. 

(In this case the Text link accepts text which might include spaces for displaying on the face of an ASP.Net Button)

The additional '**RemoveSpaces**' parameter on the 2nd TextLink specifies the use of our new StringProvider on any text before being emitted at the point of it's use.

In this case text emitted within the ID of the ASP.Net button will have the it's spaces removed.

Thus if I invoke the templates and type "**Hello World**" the emitted text will be 

	<asp:Button ID="cmdHelloWorld" runat="server" Text="Hello World" />

Note the absence of a space within the ID attribute.
