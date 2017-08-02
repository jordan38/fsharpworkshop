#load "Types.fs"
#load "Functions.fs"

open Types
open Functions

let purchases = (customer, 101M)
let vipCustomer = tryPromoteToVip purchases

let customerWith10M = getPurchases customer