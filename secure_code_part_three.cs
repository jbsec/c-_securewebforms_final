# I'm adding abbrivations to my code to save time. here is the key.
# AC: Above code. BC: Below code. 


        //reading cart size
        var cartItemCounter = Convert.ToInt32(Session["CartSize"]);
       
        
        //Saving cart and cart size in session
        Session["Cart"] = cartSession;
        Session["CartSize"] = cartItemCounter;
		
# AC: SCW says "the user removes an item from the cart the item is
# getting removed but the size of the cart is not getting decremented.

 //Retrieve product information
                SqlCommand command = new SqlCommand("SELECT top(30) * from products" , conn);
				
# AC can be changed to:

                //Retrieve product information
                SqlCommand command = new SqlCommand("SELECT top (30) * FROM products" , conn);
	
# BC can be changed to:
	
 //reading cart size
        var cartItemCounter = Convert.ToInt32(Session["CartSize"]);
		
# this, BC:

        //reading cart size
        var cartItemCounter = Convert.ToInt32(Session["CartSize"]);
        cartItemCounter--;

# Decrementing the soultion before it reaches the server. Not sure how that's a security issue
# but it is here anyway.


		