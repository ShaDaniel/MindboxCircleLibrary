SELECT DISTINCT products.name, categories.name
FROM products LEFT JOIN categories on products.id = categories.productId
