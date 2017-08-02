module Functions

open Types

let customer = { Id = 1; IsVip = false; Credit = 10M }

let tryPromoteToVip (customer, purchases) =
    if purchases > 100M then { customer with IsVip = true }
    else customer

let getPurchases customer = 
    if customer.Id % 2 = 0 then (customer, 120M)
    else (customer, 80M)
