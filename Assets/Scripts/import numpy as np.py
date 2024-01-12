import numpy as np

def dct_2d(image):
    # Apply 2D DCT to the image
    return np.fft.fft2(image)

# Example 8x8 image (replace this with your own pixel values)
image = np.array([
    [140, 144, 147, 140, 140, 155, 179, 175],
    [144, 152, 140, 147, 140, 148, 167, 179],
    [152, 155, 136, 167, 163, 162, 152, 172],
    [168, 145, 156, 160, 152, 155, 136, 160],
    [162, 148, 156, 148, 140, 136, 147, 162],
    [147, 167, 140, 155, 155, 140, 136, 162],
    [136, 156, 123, 167, 162, 144, 140, 147],
    [148, 155, 136, 155, 152, 147, 147, 136]
], dtype=np.float32)

# Apply 2D DCT
dct_result = dct_2d(image)

# Display the DCT result
print("2D DCT Result:")
print(dct_result)