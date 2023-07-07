import { FormEvent, useEffect, useState } from 'react';
import './ProductFilter.css';
import { IProductFilter } from '../../../interfaces/GlobalInterfaces';
import Typography from '../../atoms/Typography';

const ProductFilter: React.FC<IProductFilter> = ({ onFilterChange }) => {
	const [minPriceValue, setMinPriceValue] = useState('');
	const [maxPriceValue, setMaxPriceValue] = useState('');
	const [isButtonDisabled, setIsButtonDisabled] = useState(true);

	const handleFilterChange = (e: FormEvent) => {
		e.preventDefault();
		const min = Number(minPriceValue);
		const max = Number(maxPriceValue);
		onFilterChange(min, max);
	};

	const handleInputChange = (event: React.ChangeEvent<HTMLInputElement>) => {
		const { name, value } = event.target;
		if (name === 'minPrice') {
			setMinPriceValue(value);
		} else if (name === 'maxPrice') {
			setMaxPriceValue(value);
		}
	};

	useEffect(() => {
		const minPrice = Number(minPriceValue);
		const maxPrice = Number(maxPriceValue);
		const isDisabled = !(minPrice || maxPrice);
		setIsButtonDisabled(isDisabled);
	}, [minPriceValue, maxPriceValue]);

	return (
		<div className="product-filter">
			<div className="product-filter__title">
				<Typography variant="h5">Filtro de rango de precios:</Typography>
			</div>

			<form className="product-filter__form">
				<div className="product-filter__input-group">
					<label className="product-filter__label">Mínimo:</label>
					<input
						type="number"
						placeholder="Precio mínimo"
						name="minPrice"
						value={minPriceValue}
						onChange={handleInputChange}
						className="product-filter__input"
					/>
				</div>
				<div className="product-filter__input-group">
					<label className="product-filter__label">Máximo:</label>
					<input
						type="number"
						placeholder="Precio máximo"
						name="maxPrice"
						value={maxPriceValue}
						onChange={handleInputChange}
						className="product-filter__input"
					/>
				</div>
				<button
					onClick={handleFilterChange}
					className="product-filter__button"
					disabled={isButtonDisabled}
				>
					Filtrar
				</button>
			</form>
		</div>
	);
};

export default ProductFilter;
