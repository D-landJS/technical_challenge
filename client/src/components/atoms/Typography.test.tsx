import { render } from '@testing-library/react';
import Typography from './Typography';

describe('Typography', () => {
	test('renders the correct text', () => {
		const { getByText } = render(
			<Typography variant="h5">Ordenar por:</Typography>
		);

		const text = getByText('Ordenar por:');

		expect(text.textContent).toBe('Ordenar por:');
	});
});
