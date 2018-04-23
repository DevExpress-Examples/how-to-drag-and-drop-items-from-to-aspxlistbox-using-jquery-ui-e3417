# How to drag and drop items from/to ASPxListBox using jQuery UI


<p>It is not possible to drag items from ASPxListBox until the <a href="https://www.devexpress.com/Support/Center/p/S132922">Enable drag & drop in ASPxListBox</a> suggestion is implemented.<br />
The example illustrates how this functionality can be implemented using <a href="http://jqueryui.com/home"><u>jQuery UI</u></a>.</p><p><strong>See </strong><strong>also:</strong><strong><br />
</strong><a href="http://www.devexpress.com/Support/Center/Example/Details/E4109"><u>How to drag and drop items from/to ASPxListBox using jQuery UI when item's ImageUrl is used</u></a></p>


<h3>Description</h3>

<p>The example is based on the assumption that the ASPxListBox item index equals the index of a &lt;tr&gt; row (a parent of the <strong>ItemStyle.CssClass</strong> selector).<br />
If the listbox hierarchy changes between upgrades, or because of different properties, you have to adjust the following line:<br />
<code lang='js'>var itemIndex = $(ui.draggable).parent().index();</code> </p>

<br/>


