import { ChangeEvent } from 'react';
import './ProductSort.css';
import { IProductSort } from '../../../interfaces/GlobalInterfaces';
import Typography from '../../atoms/Typography';

const ProductSort: React.FC<IProductSort> = ({ sortBy, onSortChange }) => {
	const handleSortChange = (event: ChangeEvent<HTMLSelectElement>) => {
		const value = event.target.value;
		onSortChange(value);
	};

	return (
		<div className="product-sort">
			<div className="product-sort__label">
				<Typography variant="h5">Ordenar por:</Typography>
			</div>

			<select
				className="product-sort__select"
				value={sortBy}
				onChange={handleSortChange}
			>
				<option value="priceAsc">Precios más bajos</option>
				<option value="priceDesc">Precios más altos</option>
			</select>
		</div>
	);
};

export default ProductSort;
