import React from 'react';
import './ProductCard.css';
import { IProductCard } from '../../../interfaces/GlobalInterfaces';
import Paragraph from '../../atoms/Paragraph';
import Typography from '../../atoms/Typography';

const ProductCard: React.FC<IProductCard> = ({ product }) => {
	return (
		<div className="product-card">
			<div className="product-card__brand">
				<Typography variant="h4" color="secondary">
					{product.brandName}
				</Typography>
			</div>
			<div className="product-card__detail">
				<Paragraph variant="large" color="secondary">
					{product.detailName}
				</Paragraph>
			</div>

			<div className="product-card__price">
				<Paragraph color="secondary">${product.price}</Paragraph>
			</div>
		</div>
	);
};

export default ProductCard;
