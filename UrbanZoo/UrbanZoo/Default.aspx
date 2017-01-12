<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UrbanZoo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>UrbanZoo</h1>
        
        <div>
            <h2>Keepers:</h2>
            <h3>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="KID" DataSourceID="UrbanZooKeepers">
                    <Columns>
                        <asp:BoundField DataField="KID" HeaderText="KID" ReadOnly="True" SortExpression="KID" />
                        <asp:BoundField DataField="FName" HeaderText="FName" SortExpression="FName" />
                        <asp:BoundField DataField="LName" HeaderText="LName" SortExpression="LName" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                        <asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="UrbanZooKeepers" runat="server" ConnectionString="<%$ ConnectionStrings:ZooDBConnectionString %>" DeleteCommand="DELETE FROM [Keepers] WHERE [KID] = @KID" InsertCommand="INSERT INTO [Keepers] ([KID], [FName], [LName], [Gender], [Phone], [Email]) VALUES (@KID, @FName, @LName, @Gender, @Phone, @Email)" SelectCommand="SELECT * FROM [Keepers]" UpdateCommand="UPDATE [Keepers] SET [FName] = @FName, [LName] = @LName, [Gender] = @Gender, [Phone] = @Phone, [Email] = @Email WHERE [KID] = @KID">
                    <DeleteParameters>
                        <asp:Parameter Name="KID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="KID" Type="Int32" />
                        <asp:Parameter Name="FName" Type="String" />
                        <asp:Parameter Name="LName" Type="String" />
                        <asp:Parameter Name="Gender" Type="String" />
                        <asp:Parameter Name="Phone" Type="String" />
                        <asp:Parameter Name="Email" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="FName" Type="String" />
                        <asp:Parameter Name="LName" Type="String" />
                        <asp:Parameter Name="Gender" Type="String" />
                        <asp:Parameter Name="Phone" Type="String" />
                        <asp:Parameter Name="Email" Type="String" />
                        <asp:Parameter Name="KID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="UrbanZooDB" runat="server" ConnectionString="<%$ ConnectionStrings:ZooDBConnectionString %>" DeleteCommand="DELETE FROM [Enclosure] WHERE [EID] = @EID" InsertCommand="INSERT INTO [Enclosure] ([EID], [Type], [Size], [Location]) VALUES (@EID, @Type, @Size, @Location)" SelectCommand="SELECT * FROM [Enclosure]" UpdateCommand="UPDATE [Enclosure] SET [Type] = @Type, [Size] = @Size, [Location] = @Location WHERE [EID] = @EID">
                    <DeleteParameters>
                        <asp:Parameter Name="EID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="EID" Type="Int32" />
                        <asp:Parameter Name="Type" Type="String" />
                        <asp:Parameter Name="Size" Type="String" />
                        <asp:Parameter Name="Location" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Type" Type="String" />
                        <asp:Parameter Name="Size" Type="String" />
                        <asp:Parameter Name="Location" Type="String" />
                        <asp:Parameter Name="EID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </h3>
            <h2>Animals:</h2>
                
                <h3>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="AID" DataSourceID="UrbanZooAnimals" AllowSorting="True">
                    <Columns>
                        <asp:BoundField DataField="AID" HeaderText="AID" ReadOnly="True" SortExpression="AID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                        <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                        <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                        <asp:BoundField DataField="EID" HeaderText="EID" SortExpression="EID" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="UrbanZooAnimals" runat="server" ConnectionString="<%$ ConnectionStrings:ZooDBConnectionString %>" DeleteCommand="DELETE FROM [Animals] WHERE [AID] = @AID" InsertCommand="INSERT INTO [Animals] ([AID], [Name], [Type], [Gender], [DOB], [EID]) VALUES (@AID, @Name, @Type, @Gender, @DOB, @EID)" SelectCommand="SELECT * FROM [Animals]" UpdateCommand="UPDATE [Animals] SET [Name] = @Name, [Type] = @Type, [Gender] = @Gender, [DOB] = @DOB, [EID] = @EID WHERE [AID] = @AID">
                    <DeleteParameters>
                        <asp:Parameter Name="AID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="AID" Type="Int32" />
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Type" Type="String" />
                        <asp:Parameter Name="Gender" Type="String" />
                        <asp:Parameter Name="DOB" Type="DateTime" />
                        <asp:Parameter Name="EID" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Name" Type="String" />
                        <asp:Parameter Name="Type" Type="String" />
                        <asp:Parameter Name="Gender" Type="String" />
                        <asp:Parameter Name="DOB" Type="DateTime" />
                        <asp:Parameter Name="EID" Type="Int32" />
                        <asp:Parameter Name="AID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
                    </h3>
                    </div>
            
            <h2>Enclosures:</h2>
                <h3>

                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="EID" DataSourceID="UrbanZooDB">
                    <Columns>
                        
                        <asp:BoundField DataField="EID" HeaderText="EID" ReadOnly="True" SortExpression="EID" />
                        <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                        <asp:BoundField DataField="Size" HeaderText="Size" SortExpression="Size" />
                        <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                    </Columns>
                </asp:GridView>
                </h3>

            
        </div>
    

</asp:Content>
